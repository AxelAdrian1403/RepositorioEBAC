using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCiclosArreglos : MonoBehaviour
{
    //Suma de arreglos unidimensionales
    int[] arreglo1 = new int[5];
    int[] arreglo2 = new int[5];
    int[] arreglo3 = new int[5];

    //Concatenacion de palabras
    string[] palabras = new string[5] { "Hola", "como", "estas", "amigo", ":)" };
    string oracion = "";

    //Producto de matrices
    int[,] matriz = new int[,]
        {{1, 2, 3},
         {4, 5, 6}};
    int[] vector = new int[] { 7, 8, 9 };
    int[] newVector = new int[2] {0, 0};


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < arreglo1.Length; i++)
        {
            arreglo1[i] = Random.Range(1, 10);
            arreglo2[i] = Random.Range(1, 10);

            arreglo3[i] = arreglo1[i] + arreglo2[i];
        }

        Debug.Log("Suma de arreglos unidimensionales");

        for(int i = 0; i < arreglo1.Length; i++)
        {
            Debug.Log("Arreglo1[" + i + "] = " + arreglo1[i]);
            Debug.Log("Arreglo2[" + i + "] = " + arreglo2[i]);
            Debug.Log("Arreglo3[" + i + "] = " + arreglo3[i]);
        }

        Debug.Log("Concatenar palabras en una oracion");
        foreach(string i in palabras)
        {
            oracion = oracion + i + " ";
        }

        Debug.Log(oracion);

        Debug.Log("Producto de matrices");
        int k = 0;
        for(int i = 0; i < newVector.Length; i++)
        {
            for (int j = 0; j < vector.Length; j++)
            {
                newVector[i] += (matriz[k, j] * vector[j]);
            }
            k++;
        }
        for(int i = 0; i < 2; i++)
        {
            Debug.Log(newVector[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
