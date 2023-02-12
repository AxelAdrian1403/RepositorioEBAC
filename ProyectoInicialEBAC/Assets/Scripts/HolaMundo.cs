using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Información"); //Log a nivel información
        Debug.LogError("Algo salió mal"); //Log a nivel error
        Debug.LogWarning("Algo salió medianamente mal"); //Log a nivel warning
        print("Algo pasó"); //Igual a la función log, siempre y cuando tenga la herencia de MonoBehaviour
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
