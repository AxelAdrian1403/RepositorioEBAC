using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo1 : MonoBehaviour
{
    GameObject go;
    public GameObject go1, go2;
    Color color1, color2;
    bool valor1, valor2;

    private void Awake()
    {
        go = this.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        go = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        go.GetComponent<MeshRenderer>().material.color = c;
        */
        
    }

    private void FixedUpdate()
    {
        color1 = go1.GetComponent<MeshRenderer>().material.color;
        color2 = go2.GetComponent<MeshRenderer>().material.color;

        if (color1 == Color.white)
        {
            valor1 = true;
        }
        else
        {
            valor1 = false;
        }

        if (color2 == Color.white)
        {
            valor2 = true;
        }
        else
        {
            valor2 = false;
        }

        if (valor1 || valor2)
        {
            go.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            go.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
