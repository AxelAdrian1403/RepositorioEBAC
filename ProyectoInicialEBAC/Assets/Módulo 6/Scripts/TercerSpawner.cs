using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TercerSpawner : MonoBehaviour
{
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject cube = Instantiate<GameObject>(go);
        cube.name = "Cubo desde On Enable";
        cube.transform.position = new Vector3(-25, 10, 0) + Random.insideUnitSphere;
        cube.AddComponent<Rigidbody>();
    }

    private void OnDisable()
    {
        GameObject cube = Instantiate<GameObject>(go);
        cube.name = "Cubo desde On Disable";
        cube.transform.position = new Vector3(-25, 10, 0) + Random.insideUnitSphere;
        cube.AddComponent<Rigidbody>();
    }
}
