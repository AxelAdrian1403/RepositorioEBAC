using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour
{
    //Campos de la clase
    public float campo1;
    private bool campo2;
    protected float campo3 = 5;
    protected float campo4 = 4;

    //Funciones de Unity

    // Start is called before the first frame update
    void Start()
    {
        campo1 = SumaFlotantes(campo3, campo4);
        Debug.Log(campo1);
        VuelveCeroAlNumero(out campo1); //En automatico esta siendo modificada
        Debug.Log(campo1);
        ClaseNormal miClase = new ClaseNormal(campo3, campo4);
        campo1 = miClase.SumarEnteros(campo3, campo4);
        Debug.Log(campo1);
        campo1 = ClaseNormal.MultiplicarFlotantes(campo3, campo4);
        Debug.Log(campo1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Funciones propias
    // Las funciones tienen nombres con PascalCase
    public float SumaFlotantes(float a, float b)
    {
        return a + b;
    }

    public void VuelveCeroAlNumero(out float numero)
    {
        numero = 0;
    }

    //Propiedades
    //Tienen la particularidad de que son practicamente una variable pero tienen lo que se llaman metodos accesores
    //Te ayudan a tener las variables como privadas y las propiedades como publicas

    public int propiedad1 { get; set; }
    public bool propiedad2 { get; set; }
    public float propiedadSoloLectura { get; }
}
