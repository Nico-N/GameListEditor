using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace GameListEditor
{
    class Helper
    {

        public static void SaveGamelist(GameEntry[] gameListEntrys, string relativeImagePath, string xmlFile)
        {

            try
            {

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter xmlWriter = XmlWriter.Create(xmlFile,settings);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("gameList");

                foreach (GameEntry entry in gameListEntrys)
                {
                    xmlWriter.WriteStartElement("game");
                    
                    if (!String.IsNullOrEmpty(entry.ID))
                        xmlWriter.WriteAttributeString("id", entry.ID);

                    if (!String.IsNullOrEmpty(entry.Datasource))
                        xmlWriter.WriteAttributeString("source", entry.Datasource);

                    if (!String.IsNullOrEmpty(entry.Path))
                    {
                        xmlWriter.WriteStartElement("path");
                        xmlWriter.WriteString("./"+entry.Path);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Name))
                    {
                        xmlWriter.WriteStartElement("name");
                        xmlWriter.WriteString(entry.Name);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Description))
                    {
                        xmlWriter.WriteStartElement("desc");
                        xmlWriter.WriteString(entry.Description);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Image))
                    {
                        xmlWriter.WriteStartElement("image");
                        xmlWriter.WriteString(relativeImagePath + "/" + entry.Image);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Rating))
                    {
                        xmlWriter.WriteStartElement("rating");
                        xmlWriter.WriteString(entry.Rating);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.ReleaseDate))
                    {
                        xmlWriter.WriteStartElement("releasedate");
                        xmlWriter.WriteString(entry.ReleaseDate);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Developer))
                    {
                        xmlWriter.WriteStartElement("developer");
                        xmlWriter.WriteString(entry.Developer);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Publisher))
                    {
                        xmlWriter.WriteStartElement("publisher");
                        xmlWriter.WriteString(entry.Publisher);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Genre))
                    {
                        xmlWriter.WriteStartElement("genre");
                        xmlWriter.WriteString(entry.Genre);
                        xmlWriter.WriteEndElement();
                    }

                    if (!String.IsNullOrEmpty(entry.Players))
                    {
                        xmlWriter.WriteStartElement("players");
                        xmlWriter.WriteString(entry.Players);
                        xmlWriter.WriteEndElement();
                    }

                    if (entry.Hidden)
                    {
                        xmlWriter.WriteStartElement("hidden");
                        xmlWriter.WriteString("true");
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error saving gamelist file");               
            }

        }

        public static string RemoveAppendedSlash(string inStr)
        {
            
            int cutPoint;

            if (!String.IsNullOrEmpty(inStr))
            {
                if (inStr[inStr.Length - 1] == '\\')
                {
                    cutPoint = inStr.LastIndexOf('\\');
                    return inStr.Substring(0, cutPoint);
                }
                else if (inStr[inStr.Length - 1] == '/')
                {
                    cutPoint = inStr.LastIndexOf('/');
                    return inStr.Substring(0, cutPoint);
                }
                else
                {
                    return inStr;
                } 
            }
            else
            {
                return inStr;
            }

        }

        public static string GetExtensionList(string inputString)
        {
            string outputString = "";
            List<string> extList = new List<string>();

            Regex r1 = new Regex(@"[A-Za-z0-9]+");

            if (!String.IsNullOrEmpty(inputString))
            {
                Match match = r1.Match(inputString);
                while (match.Success)
                {
                    if (!extList.Contains(match.Value.ToLower())) extList.Add(match.Value.ToLower());
                    match = match.NextMatch();
                }

                foreach (string ext in extList)
                {
                    if (String.IsNullOrEmpty(outputString))
                        outputString = "*." + ext;
                    else
                        outputString += ",*." + ext;
                } 
            }

            return outputString;
        }

    }
}
