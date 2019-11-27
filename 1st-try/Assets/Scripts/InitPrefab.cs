using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPrefab : MonoBehaviour
{
    public GameObject prefab;

    public int posY;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Init prefab: " + prefab);

        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(prefab, new Vector3(1, posY, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
