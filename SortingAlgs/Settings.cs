using System;
using System.IO;
using Newtonsoft.Json;

namespace SortingAlgs
{
    public class Settings
    {
        public bool AscendingOrder { get; set; }
        public bool RememberNumbers { get; set; }
        public int[] Numbers { get; set; }

        public Settings()
        {
            AscendingOrder = true;
            RememberNumbers = false;
        }

        public Settings(bool _asc, bool _remembernums, int[] nums)
        {
            AscendingOrder = _asc;
            RememberNumbers = _remembernums;
            Numbers = nums;
        }

        public static void SaveSettings(string fileName, Settings settings)
        {
            try
            {
                string output = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(fileName, output);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error saving settings: {0}", ex.Message);
            }
        }

        public static Settings LoadSettings(string fileName)
        {
            try
            {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(fileName));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading settings: {0}", ex.Message);
                return new Settings();
            }
        }
    }
}
