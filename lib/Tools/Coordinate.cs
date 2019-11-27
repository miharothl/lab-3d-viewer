using System;
namespace Tools
{
    public static class Coordinate
    {
        public static double ToRad(double angle)
        {
            return ((2 * Math.PI) / 360) * angle;
        }

        public static (double, double, double) LatlngToXyz(double lat, double lng, double r=6371)
        {
            var theta = (Math.PI / 2) - ToRad(lat);

            var phi = ToRad(lng);

            var x = r * Math.Sin(theta) * Math.Cos(phi);
            var y = r * Math.Sin(theta) * Math.Sin(phi);
            var z = r * Math.Cos(theta);

            var xyz = (X: x , Y: y, Z: z);

            return xyz;
        }

        public static void LongLatToPPP(float lon, float lat)
        {
            double r = 6371;

            double theta = Math.PI / 2;
        }
    }
}
