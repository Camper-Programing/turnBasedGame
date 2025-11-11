using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace turnBasedGame.GameConfig
{
    public static class ConfigLoader
    {
        public static (int maxX, int maxY, string difficulty) LoadConfig(string filePath)
        {
            /*if (!File.Exists(filePath))
                throw new FileNotFoundException($"Configuration file not found: {filePath}");//In case the XML file can't be found*/
            
            int maxX = (int?)worldElement.Element("MaxX")
                ?? throw new InvalidDataException("Missing <MaxX>.");
            int maxY = (int?)worldElement.Element("MaxY")
                ?? throw new InvalidDataException("Missing <MaxY>.");
            string difficulty = (string?)doc.Root?.Element("Difficulty")
                ?? "Normal";

            return (maxX, maxY, difficulty);
        }
    }
}
