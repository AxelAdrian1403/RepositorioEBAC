using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDeCero : MonoBehaviour
{
    GameObject objToSpawn; // Declarar GameObject
    Vector3[] vertices = //Declarar arreglo de vértices para nuestro cubo
    {
        new Vector3(0, 0, 0), //vértice 0
        new Vector3(1, 0, 0), //vértice 1
        new Vector3(1, 1, 0), //vértice 2
        new Vector3(0, 1, 0), //vértice 3
        new Vector3(0, 1, 1), //vértice 4
        new Vector3(1, 1, 1), //vértice 5
        new Vector3(1, 0, 1), //vértice 6
        new Vector3(0, 0, 1)  //vértice 7
    };

    int[] triangulos = //Declarar las conexiones de los vértices para formar triángulos y a su vez caras
    {
        0,2,1, //Cara 1
        0,3,2,
        2,3,4, //Cara 2
        2,4,5,
        1,2,5, //Cara 3
        1,5,6,
        0,7,4, //Cara 4
        0,4,3,
        5,4,7, //Cara 5
        5,7,6,
        0,6,7, //Cara 6
        0,1,6
    };


    // Start is called before the first frame update
    void Start()
    {
        //Instanciar cubo
        objToSpawn = new GameObject("Nuestro Primer Cubo"); //Instanciar
        objToSpawn.AddComponent<MeshFilter>();  //Agregar un Mesh Filter
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh; //Obtener el Mesh de nuestro componente Mesh Filter

        //Modificar Mesh
        meshFilter.Clear(); //Limpiar el mesh por si había basura
        meshFilter.vertices = vertices; //Darle los vértices
        meshFilter.triangles = triangulos; //Darlelos triángulos
        meshFilter.Optimize(); //Optimizar mesh para posterior renderizado
        meshFilter.RecalculateNormals(); //Normalizar las caras

        //Agregar Collider
        objToSpawn.AddComponent<BoxCollider>(); //Agregar un Box Collider
        var boxCollider = objToSpawn.GetComponent<BoxCollider>(); //Obtener box collider
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f); //Darle ubicación a su centro con respecto del GameObject

        //Agregar Mesh Renderer
        objToSpawn.AddComponent<MeshRenderer>(); //Mesh Renderer
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material; //Obtener material del Mesh Renderer
        meshRendererMaterial.color = Color.red; //Definir color del material

        //Ubicar el cubo
        objToSpawn.transform.position = Vector3.one;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
