using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        char c = '9';
        char ck = 'k';

        int valorEntero = (int)char.GetNumericValue(c) + 5; //Convertir un char a un valor numérico
        int valorEntero2 = c - '5';
        int valorEntero3 = int.Parse(c.ToString());
        int valorEntero4 = 0;

        if(!int.TryParse(ck.ToString(), out valorEntero4))
        {
            Debug.LogError("Eso no es un tipo de dato válido");
        }
        else
        {
            Debug.Log(valorEntero4);
        }

        Debug.Log(valorEntero);
        Debug.Log(valorEntero2);
        Debug.Log(valorEntero3);

        char miCaracter;
        string miString = "Hola desde EBAC";
        miCaracter = miString[3];
        Debug.Log(miCaracter);

        int longitud = miString.Length;
        Debug.Log(longitud);

        string miSegundoString = miString.Replace('e', 'E');
        Debug.Log(miSegundoString);
        miSegundoString = miString.ToUpper();
        Debug.Log(miSegundoString);

        string tercerString = miString + " " + miSegundoString;
        Debug.Log(tercerString);

        string ejemploEscape = "\"";

        //Interpolación
        string miNombre = "Adrián";
        string misApellidos = "Flores Álvarez";
        string salida = $"Mi nombre es: {miNombre}, y mis apellidos son: {misApellidos}";
        string salidaSuma = "Mi nombre es: " + miNombre + ", y mis apellidos son: " + misApellidos;

        Debug.Log(salida);
        Debug.Log(salidaSuma);

        string primerApellido = misApellidos.Substring(0, 6);
        Debug.Log(primerApellido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
