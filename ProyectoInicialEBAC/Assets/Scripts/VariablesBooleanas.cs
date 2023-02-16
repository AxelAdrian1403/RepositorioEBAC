using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

    int limiteInferior = 0;
    int limiteSuperior = 5;

    int limiteInferior1 = -5;
    int limiteSuperior1 = 5;

    enum seleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

    /*
        A B           OR AND
        1 1            1  1 
        1 0            1  0
        0 1            1  0
        0 0            0  0
     */

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;

        if(variable1) //variable == true
        {
            Debug.Log("Esta variable es verdadera");
            Debug.Log("Ya tienes el valor de variable 1");
        }

        if(!variable2) //variable == false
        {
            Debug.Log("Esta variable es falsa");
            Debug.Log("Ya tienes el valor de variable 2");
        }    

        if(valor1 < 5)
        {
            Debug.Log("El valor de la variable es menor a 5");
        }

        if(variable1 && variable2)
        {
            Debug.Log("La operación dio resultado TRUE");
        }
        else
        {
            Debug.Log("La operación dio resultado FALSE");
        }

        if (variable1 || variable2)
        {
            Debug.Log("La operación dio resultado TRUE");
        }
        else
        {
            Debug.Log("La operación dio resultado FALSE");
        }

        if(!variable2)
        {
            Debug.Log("La variable es falsa");
        }

        valor1 = Random.Range(limiteInferior, limiteSuperior); //El límite superior no se incluye
        Debug.Log(valor1);

        switch(valor1)
        {
            case (int)seleccionColor.rojo when variable1 == true: //Se hace una doble validación con la palabra when, así se compara si se tiene un caso, y además, otra condición
                // case condicion when otraCondicion == algo
                Debug.Log("El color seleccionado es el rojo");
                break;
            case (int)seleccionColor.verde:
                Debug.Log("El color seleccionado es el verde");
                break;
            case (int)seleccionColor.azul:
                Debug.Log("El color seleccionado es el azul");
                break;
            case (int)seleccionColor.blanco:
                Debug.Log("El color seleccionado es el blanco");
                break;
            case (int)seleccionColor.gris:
                Debug.Log("El color seleccionado es el gris");
                break;
            default:
                Debug.Log("Ese valor no existe");
                break;
        }

        //Operador unario
        int valor2 = Random.Range(limiteInferior1, limiteSuperior1);
        string resultado = (valor2 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
