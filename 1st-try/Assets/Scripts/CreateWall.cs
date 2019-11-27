using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class CreateWall : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;

    // Start is called before the first frame update
    void Start()
    { 
        Debug.Log(Tools.HelloWorld.GetMessage("Unity"));

        Debug.Log("Create wall with: " + block);

        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
