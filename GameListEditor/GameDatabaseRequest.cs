using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GameListEditor
{
    /// <summary>
    /// Helper Class for getting game data from thegamesdb.net
    /// </summary>
    class GameDatabaseRequest
    {
        /// <summary>
        /// Make a request with the given requestURL and return the XML response as XmlDocument
        /// If an error occurs -> show an error messagebox and return null
        /// </summary>
        /// <param name="requestUrl"></param>
        /// <returns></returns>
        private static XmlDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return (xmlDoc);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        private static string GetNodeDataFromResponse(XmlDocument response, string nodePath)
        {
            string returnString = null;

            try
            {
                returnString = response.SelectSingleNode(nodePath).InnerText;
            }
            catch
            {
                returnString = null;
            }

            return returnString;
        }

        private static string GetNodeDataFromNode(XmlNode node, string nodePath)
        {
            string returnString = null;

            try
            {
                returnString = node.SelectSingleNode(nodePath).InnerText;
            }
            catch
            {
                returnString = null;
            }

            return returnString;
        }

        private static string GetTitle(XmlDocument response)
        {
            return GetNodeDataFromResponse(response, "/Data/Game/GameTitle");
        }

        private static string GetOverwiew(XmlDocument response)
        {
            return GetNodeDataFromResponse(response, "/Data/Game/Overview");
        }

        private static string GetRating(XmlDocument response)
        {
            string gameDBRating = GetNodeDataFromResponse(response, "/Data/Game/Rating");

            if (gameDBRating != null)
            {
                int rating = (int)Math.Round(float.Parse(gameDBRating, CultureInfo.InvariantCulture), 0);

                switch (rating)
                {
                    case 10: return "1";
                    case 9: return "0.9";
                    case 8: return "0.8";
                    case 7: return "0.7";
                    case 6: return "0.6";
                    case 5: return "0.5";
                    case 4: return "0.4";
                    case 3: return "0.3";
                    case 2: return "0.2";
                    case 1: return "0.1";
                    case 0: return "0.0";
                    default: return null;

                }
            }
            else
            {
                return null;
            }

        }

        private static string GetReleaseDate(XmlDocument response)
        {
            string gameDBReleaseDate = GetNodeDataFromResponse(response, "/Data/Game/ReleaseDate");

            if (gameDBReleaseDate != null)
            {

                string year = "";
                string month = "";
                string day = "";

                string[] tempString = gameDBReleaseDate.Split('/');

                if (tempString.Length == 3)
                {
                    month = tempString[0];
                    day = tempString[1];
                    year = tempString[2];
                }

                string releaseDate = year + month + day + "T000000";

                if (releaseDate.Length == 15)
                    return releaseDate;
            }

            return null;

        }

        private static string GetDeveloper(XmlDocument response)
        {
            return GetNodeDataFromResponse(response, "/Data/Game/Developer");
        }

        private static string GetPublisher(XmlDocument response)
        {
            return GetNodeDataFromResponse(response, "/Data/Game/Publisher");
        }

        private static string GetGenre(XmlDocument response)
        {

            string returnString = null;

            try
            {
                XmlNode genreListNode = response.SelectSingleNode("/Data/Game/Genres");
                XmlNodeList genreNodeList = genreListNode.SelectNodes("genre");
                foreach (XmlNode node in genreNodeList)
                {
                    if (returnString == null)
                        returnString = node.InnerText;
                    else
                        returnString += "/" + node.InnerText;
                }
            }
            catch
            {

            }

            return returnString;
        }

        private static string GetImageURL(XmlDocument response)
        {

            string returnString = null;
            string tempString = null;

            returnString = GetNodeDataFromResponse(response, "/Data/baseImgUrl");

            if (returnString == null)
                return null;

            //try to get the first front-boxart image url            
            try
            {
                XmlNode imagesListNode = response.SelectSingleNode("/Data/Game/Images");
                XmlNodeList boxartNodeList = imagesListNode.SelectNodes("boxart");
                foreach (XmlNode node in boxartNodeList)
                {
                    if (node.Attributes.GetNamedItem("side").Value == "front")
                    {
                        returnString += node.InnerText;
                        return returnString;
                    }

                }
            }
            catch
            {

            }

            //try to get any boxart image url
            tempString = GetNodeDataFromResponse(response, "/Data/Game/Images/boxart");
            if (tempString != null)
                return returnString + tempString;

            //try to get any screenshot image url
            tempString = GetNodeDataFromResponse(response, "/Data/Game/Images/screenshot/original");
            if (tempString != null)
                return returnString + tempString;

            //try to get any fanart image url
            tempString = GetNodeDataFromResponse(response, "/Data/Game/Images/fanart/original");
            if (tempString != null)
                return returnString + tempString;

            //return null if nothing was found
            return null;
        }

        private static string GetPlayers(XmlDocument response)
        {
            return GetNodeDataFromResponse(response, "/Data/Game/Players");
        }



        public static GameEntry GetGameEntryByID(string id)
        {

            GameEntry returnEntry = new GameEntry();

            XmlDocument response = MakeRequest("http://thegamesdb.net/api/GetGame.php?id=" + id);

            if (response != null)
            {
                returnEntry.Name = GetTitle(response);
                returnEntry.Description = GetOverwiew(response);
                returnEntry.Rating = GetRating(response);
                returnEntry.ReleaseDate = GetReleaseDate(response);
                returnEntry.Developer = GetDeveloper(response);
                returnEntry.Publisher = GetPublisher(response);
                returnEntry.Genre = GetGenre(response);
                returnEntry.Players = GetPlayers(response);
                returnEntry.ID = id;
                returnEntry.Datasource = "theGamesDB.net";
                returnEntry.ImageURL = GetImageURL(response);
            }
            else
            {
                return null;
            }

            if (String.IsNullOrEmpty(returnEntry.Name) &&
                String.IsNullOrEmpty(returnEntry.Description) &&
                String.IsNullOrEmpty(returnEntry.Rating) &&
                String.IsNullOrEmpty(returnEntry.ReleaseDate) &&
                String.IsNullOrEmpty(returnEntry.Developer) &&
                String.IsNullOrEmpty(returnEntry.Publisher) &&
                String.IsNullOrEmpty(returnEntry.Genre) &&
                String.IsNullOrEmpty(returnEntry.Players) &&
                String.IsNullOrEmpty(returnEntry.ImageURL))
                return null;
            else
                return returnEntry;
        }

        private static GameSearchItem GetSearchItemFromNode(XmlNode node)
        {

            GameSearchItem returnItem = new GameSearchItem();

            returnItem.ID = GetNodeDataFromNode(node, "id");
            returnItem.Name = GetNodeDataFromNode(node, "GameTitle");
            returnItem.ReleaseDate = GetNodeDataFromNode(node, "ReleaseDate");
            returnItem.Platform = GetNodeDataFromNode(node, "Platform");

            return returnItem;

        }

        private static GameSearchItem[] GetSearchQueryResultFromResponse(XmlDocument response)
        {
            List<GameSearchItem> searchResults = new List<GameSearchItem>();

            try
            {
                XmlNode resultListNode = response.SelectSingleNode("/Data");
                XmlNodeList resultNodeList = resultListNode.SelectNodes("Game");
                foreach (XmlNode node in resultNodeList)
                {
                    GameSearchItem temp = GetSearchItemFromNode(node);
                    searchResults.Add(temp);
                }
            }
            catch
            {

            }


            return searchResults.ToArray();

        }

        private static string[] GetPlatformListFromResponse(XmlDocument response)
        {
            List<string> searchResults = new List<string>();

            try
            {
                XmlNode resultListNode = response.SelectSingleNode("/Data");
                XmlNodeList resultNodeList = resultListNode.SelectNodes("Platforms/Platform");
                foreach (XmlNode node in resultNodeList)
                {
                    string temp = GetNodeDataFromNode(node, "name");
                    searchResults.Add(temp);
                }
            }
            catch
            {

            }


            return searchResults.ToArray();

        }

        public static GameSearchItem[] GetSearchQueryResult(string searchString, string platform)
        {


            XmlDocument response;

            if (String.IsNullOrEmpty(platform))
                response = MakeRequest("http://thegamesdb.net/api/GetGamesList.php?name=" + searchString);
            else
                response = MakeRequest("http://thegamesdb.net/api/GetGamesList.php?name=" + searchString + "&platform=" + platform);

            if (response != null)
            {
                return GetSearchQueryResultFromResponse(response);
            }
            else
            {
                return null;
            }





        }

        public static string[] GetPlatformList()
        {
            XmlDocument response;

            response = MakeRequest("http://thegamesdb.net/api/GetPlatformsList.php");

            if (response != null)
            {
                return GetPlatformListFromResponse(response);
            }
            else
            {
                return null;
            }
        }


    }
}
