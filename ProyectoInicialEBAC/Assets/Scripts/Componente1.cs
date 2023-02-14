using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto; //Crear una variable en memoria

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        miObjeto = this.gameObject; //Hace referencia a la instancia de Componente1, y solicitamos que nos pase el GameObject al que está linkeado
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
