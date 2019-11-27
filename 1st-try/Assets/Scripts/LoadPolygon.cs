using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using GeoJSON.Net.Feature;



using Tools;

public class LoadPolygon : MonoBehaviour
{
    public GameObject block;


    public String pathToPolygon;

    // Start is called before the first frame update
    void Start()
    {

        var obj = Instantiate(block, new Vector3(0, 0, 0), Quaternion.identity);
        obj.transform.localScale += new Vector3(12742, 12742, 12742);

        var colors = new List<Color>();
        colors.Add(Color.black);
        colors.Add(Color.blue);
        colors.Add(Color.cyan);
        colors.Add(Color.gray);
        colors.Add(Color.magenta);
        colors.Add(Color.red);
        colors.Add(Color.white);
        colors.Add(Color.yellow);
        colors.Add(Color.black);
        colors.Add(Color.blue);
        colors.Add(Color.cyan);
        colors.Add(Color.gray);
        colors.Add(Color.magenta);
        colors.Add(Color.red);
        colors.Add(Color.white);
        colors.Add(Color.yellow);
        colors.Add(Color.black);
        colors.Add(Color.blue);
        colors.Add(Color.cyan);
        colors.Add(Color.gray);
        colors.Add(Color.magenta);
        colors.Add(Color.red);
        colors.Add(Color.white);
        colors.Add(Color.yellow);
        colors.Add(Color.black);
        colors.Add(Color.blue);
        colors.Add(Color.cyan);
        colors.Add(Color.gray);
        colors.Add(Color.magenta);
        colors.Add(Color.red);
        colors.Add(Color.white);
        colors.Add(Color.yellow);


        //var root = Tools.Polygon.Load(@"/Users/rothlmi/scm/tt/hub/lab-3d-viewer/data/ireland.json");
        var root = Tools.Polygon.Load(pathToPolygon);

        int color_index = 0;

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
                            var lng = c.Longitude;

                            var point = Coordinate.LatlngToXyz(lng, lat);

                            obj = Instantiate(block, new Vector3(Convert.ToSingle(point.Item1), Convert.ToSingle(point.Item2), Convert.ToSingle(point.Item3)), Quaternion.identity);
                            //obj.gameObject.tag = feature.Properties["id"];

                            Renderer rend = obj.GetComponent<Renderer>();
                            rend.material.color = colors[color_index];
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

                                var point = Coordinate.LatlngToXyz(lng, lat);

                                obj = Instantiate(block, new Vector3(Convert.ToSingle(point.Item1), Convert.ToSingle(point.Item2), Convert.ToSingle(point.Item3)), Quaternion.identity);
                                //obj.gameObject.tag = feature.Properties["id"];

                                Renderer rend = obj.GetComponent<Renderer>();
                                rend.material.color = colors[color_index];
                            }
                        }
                    }
                    break;
            }

            color_index = color_index + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
