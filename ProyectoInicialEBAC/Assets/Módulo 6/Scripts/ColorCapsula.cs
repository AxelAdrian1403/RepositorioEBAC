using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCapsula : MonoBehaviour
{
    GameObject go;
    public bool cambioColor = false;
    private void Awake()
    {
        go = this.gameObject;
        /*
        Color c = new Color(Random.value, Random.value, Random.value);
        go.GetComponent<MeshRenderer>().material.color = c;
        */
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (!cambioColor)
        {
            cambioColor = true;
            go.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else
        {
            cambioColor = false;
            go.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
