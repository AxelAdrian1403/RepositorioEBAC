using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerSpawner : MonoBehaviour
{
    public GameObject go;

    private void Awake()
    {
        GameObject cube = Instantiate<GameObject>(go);
        cube.name = "Cubo en Awake";
        cube.transform.position = new Vector3(-35, 10, 0);
        cube.AddComponent<Rigidbody>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
