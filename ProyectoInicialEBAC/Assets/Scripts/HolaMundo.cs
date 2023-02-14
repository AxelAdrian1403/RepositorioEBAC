using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        Debug.LogError("Algo salió mal"); //Log a nivel error
        Debug.LogWarning("Algo salió medianamente mal"); //Log a nivel warning
        print("Algo pasó"); //Igual a la función log, siempre y cuando tenga la herencia de MonoBehaviour
    }

    // Update is called once per frame
    void Update()
    {
        /*
            x += 1;
            Debug.Log("Información"); //Log a nivel información
            Debug.Log("x -> " + x);
        */
        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.Log("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto ha sido inhabilitado");
    }
}
