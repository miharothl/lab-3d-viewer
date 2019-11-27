using System;
using Xunit;

using Tools;

namespace Tools.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedMessage = "Hello Unity!";
            var actualMessage = HelloWorld.GetMessage("Unity");
            Assert.Equal(expectedMessage, actualMessage);
        }

        [Fact]
        public void Test2()
        { 
            var root = Tools.Polygon.Load(@"../../../../../data/ireland.json");

            Assert.NotNull(root);

            foreach (var feature in root.Features)
            {
                var id = feature.Properties["id"];

                switch (feature.Geometry.Type)
                {
                    case GeoJSON.Net.GeoJSONObjectType.Polygon:

                        var polygon = feature.Geometry as GeoJSON.Net.Geometry.Polygon;

                        foreach (var coordinate in polygon.Coordinates)
                        {
                            foreach (var c in coordinate.Coordinates)
                            {
                                var lat = c.Latitude;
                                var lgn = c.Longitude;
                            }
                        }
                        break;

                    case GeoJSON.Net.GeoJSONObjectType.MultiPolygon:

                        var multipolygon = feature.Geometry as GeoJSON.Net.Geometry.MultiPolygon;

                        foreach (var coordinate in multipolygon.Coordinates)
                        {
                            foreach (var c in coordinate.Coordinates)
                            {
                                foreach (var cc in c.Coordinates)
                                {
                                    var lat = cc.Latitude;
                                    var lng = cc.Longitude;
                                }
                            }
                        }
                        break;
                }
            }
        }
 
        [Fact]
        public void Test3()
        {
            var result = Coordinate.ToRad(90);
            var expect = Math.PI /2;

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test4()
        {
            var result = Math.Sin(Math.PI/2);
            var expect = 1;
            
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Test5()
        {
            var lon = -6.105263;
            var lat = 53.219391;

            var result = Coordinate.LatlngToXyz(lat, lon);
            var expect = (3793.0165787463125, -405.70893226118244, 5102.7508753258871);

            Assert.Equal(expect, result);
        }
    }
}
