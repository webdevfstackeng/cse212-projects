using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
/* "properties":{"mag":1.76,"place":"2 km NNW of The Geysers, CA" */

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public class Metadata {
        public static double Generated {get; set;}
        public static string Url {get; set;}
        public static string Title {get; set;}
        public static int Status {get; set;}
        public static string Api {get; set;}
        public static int Count {get; set;}
    }
    
    public class Geometry {
        //public static Type 
        public static string Type {get; set;}
        public static Coordinates [] Measures {get; set;}
        public static string Id {get; set;}

    }

    public class Coordinates
    {
        public static float Points {get; set;}
    }
    public class Location
    {
        public static Property [] Properties {get; set;}
        public static Property TheProperties {get; set;}
         
    }

    public class Property 
    {
        public double Mag { get; set;}
        public string Place { get; set;}
        public double Time { get; set;}
        public double Updated { get; set;}
        public string Tz { get; set;}
        public string Url {get; set;}
        public string Detail {get; set;}
        public string Felt { get; set;}
        public double Cdi { get; set;}
        public double Mmi { get; set;}
        public double Alert { get; set;}
        public string Status {get; set;}
        public int Tsunami {get; set;}
        public int Sig {get; set;}
        public string Net { get; set;}
        public string Code { get; set;}
        public string Ids { get; set;}
        public string Sources { get; set;}
        public string Types { get; set;}
        public int Nst { get; set;}
        public double Dmin { get; set;}
        public double Rms { get; set;}
        public int Gap { get; set;}
        public string MagType { get; set;}
        public string Type { get; set;}
        public string Title { get; set;}
    }
}