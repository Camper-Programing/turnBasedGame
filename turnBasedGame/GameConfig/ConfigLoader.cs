using System;
using System.IO;
using System.Xml.Linq;

namespace turnBasedGame.Config
{
    public static class ConfigLoader
    {
        public static (int maxX, int maxY, string difficulty) LoadConfig(string filePath)
        {
            if (!File.Exists(filePath))
                
                throw new FileNotFoundException($"Configuration file not found: {Path.GetFullPath(filePath)}");

            XDocument doc;
            try
            {
                doc = XDocument.Load(filePath);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to load XML config: {filePath}", ex);
            }

            var root = doc.Root ?? throw new InvalidDataException("Config root element missing.");
            var worldElement = root.Element("World") ?? throw new InvalidDataException("Missing <World> element.");
            int maxX = int.Parse(worldElement.Element("MaxX")?.Value ?? throw new InvalidDataException("Missing <MaxX>."));
            int maxY = int.Parse(worldElement.Element("MaxY")?.Value ?? throw new InvalidDataException("Missing <MaxY>."));
            string difficulty = root.Element("Difficulty")?.Value ?? "Normal";
            return (maxX, maxY, difficulty);
        }
    }
}
