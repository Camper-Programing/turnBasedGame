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
            

            var doc = XDocument.Load(filePath);
            var worldElement = doc.Element("GameConfig").Element("World");
            int maxX = int.Parse(worldElement.Element("MaxX").Value);
            int maxY = int.Parse(worldElement.Element("MaxY").Value);
            string difficulty = doc.Root.Element("Difficulty").Value;
            return (maxX, maxY, difficulty);
        }
    }
}
