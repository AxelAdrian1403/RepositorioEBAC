using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        go = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        go.GetComponent<MeshRenderer>().material.color = c;
    }
}
