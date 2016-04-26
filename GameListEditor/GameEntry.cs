using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameListEditor
{
    public class GameEntry
    {

        public string Path { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public string Players { get; set; }
        public string ID { get; set; }
        public string Datasource { get; set; }
        public string ImageURL { get; set; }
        public bool Hidden { get; set; }

        public GameEntry(string path)
        {
            Path = path;
        }

        public GameEntry()
        {
            // TODO: Complete member initialization
        }

    }
}
