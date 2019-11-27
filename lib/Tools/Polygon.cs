using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using GeoJSON.Net.Feature;


namespace Tools
{
    // public class Properties
    // {
    //     public string id { get; set; }
    // }

    // public class Geometry
    // {
    //     public string type { get; set; }
    //     public List<List<List<List<object>>>> coordinates { get; set; }
    // }

    // public class Feature
    // {
    //     public string type { get; set; }
    //     public Properties properties { get; set; }
    //     public Geometry geometry { get; set; }
    // }

    // public class Root
    // {
    //     public string type { get; set; }
    //     public List<Feature> features { get; set; }
    // }

    public static class Polygon
    {
        public static class HelloWorld
        {
            public static string GetMessage(string name) => $"Hello {name}!";
        }

        public static FeatureCollection Load(string pathToFile)
        {
            try
            {
                var json = File.ReadAllText(pathToFile);

                System.Diagnostics.Debug.WriteLine(json);

                var ireland = JsonConvert.DeserializeObject<FeatureCollection>(json);

                return ireland;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
