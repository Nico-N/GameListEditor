using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GameListEditor
{
    class GameListFile
    {

        private List <GameEntry> gameList;

        public GameListFile(string filename)
        {

            gameList = new List<GameEntry>();

            try
            {
                using (XmlReader reader = XmlReader.Create(filename))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement() && reader.Name.ToString().ToLower().Equals("game"))
                        {
                            GameEntry newEntry = new GameEntry();

                            newEntry.ID = reader.GetAttribute("id");
                            newEntry.Datasource = reader.GetAttribute("source");

                            while (reader.Read())
                            {
                                if (reader.IsStartElement())
                                {
                                    switch (reader.Name.ToString().ToLower())
                                    {
                                        case "path": newEntry.Path = DisposePathInfo(reader.ReadString());
                                            break;
                                        case "name": newEntry.Name = reader.ReadString();
                                            break;
                                        case "desc": newEntry.Description = reader.ReadString().Replace("\r\n", "\n").Replace("\n", "\r\n");
                                            break;
                                        case "image": newEntry.Image = DisposePathInfo(reader.ReadString());
                                            break;
                                        case "rating": newEntry.Rating = reader.ReadString();
                                            break;
                                        case "releasedate": newEntry.ReleaseDate = reader.ReadString();
                                            break;
                                        case "developer": newEntry.Developer = reader.ReadString();
                                            break;
                                        case "publisher": newEntry.Publisher = reader.ReadString();
                                            break;
                                        case "genre": newEntry.Genre = reader.ReadString();
                                            break;
                                        case "players": newEntry.Players = reader.ReadString();
                                            break;
                                        case "hidden": string hidden = reader.ReadString();
                                                       if (hidden.ToLower().Equals("true"))
                                                           newEntry.Hidden = true;
                                                       else
                                                           newEntry.Hidden = false;
                                            break;
                                    } //End of current game element (switch)
                                } //next game element
                                else break;
                            } //end of inner loop of game elements

                            gameList.Add(newEntry);

                        } //end of current game 
                    } //next game

                } //end of using - Dispose XmlReader
            }
            catch 
            {
                
                
            }
 

        } //End of constructor method

        private string DisposePathInfo(string inputString)
        {
            int cutPoint = inputString.LastIndexOf('/');
            return inputString.Substring(cutPoint+1);
        }

        public GameEntry[] GetGameListAsArray()
        {
            GameEntry[] gameListArray = new GameEntry[gameList.Count];
            gameListArray = gameList.ToArray();
            return gameListArray;
        }

        public string[] GetAllRoms()
        {
            List<string> romList = new List<string>();

            foreach (GameEntry entry in gameList)
                romList.Add(entry.Path);

            return romList.ToArray();
        }

        public GameEntry GetGameByPath(string path)
        {
            GameEntry returnEntry = new GameEntry(path);

            foreach (GameEntry e in gameList) 
            {
                if (e.Path.Equals(path))
                    returnEntry = e;
            }

            return returnEntry;
        }

    }
}
