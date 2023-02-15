using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoSpawner : MonoBehaviour
{
    public GameObject go;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject cube = Instantiate<GameObject>(go);
        cube.name = "Cubo desde Update " + numCubos;
        cube.transform.position = new Vector3(-30, 10, 0) + Random.insideUnitSphere;
        cube.AddComponent<Rigidbody>();

        listaDeCubos.Add(cube);
        List<GameObject> listaEliminar = new List<GameObject>();

        foreach(GameObject g in listaDeCubos)
        {
            float scale = g.transform.localScale.x;
            scale *= factorDeEscalamiento;
            g.transform.localScale = Vector3.one * scale;

            if(scale <= 0.1)
            {
                listaEliminar.Add(g);
            }
        }

        foreach(GameObject g in listaEliminar)
        {
            listaDeCubos.Remove(g);
            Destroy(g);
        }
    }
}
