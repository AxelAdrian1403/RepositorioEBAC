using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    //For           =>  Sabemos cuántas veces se repite el ciclo 
    //While         => No sabemos cuántas veces vamos a repetir el ciclo
    //Do While      => Al menos una vez se ejecuta
    //Arreglos      
    //Foreach

    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        //For
        /*
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        Debug.Log("\n");

        for (int i = 10; i > 1; i--)
        {
            Debug.Log(i);
        }
        */

        /*
        //Sentencia While
        //Un ciclo infinito podría generar que se trabe el motor, por lo que habría que reiniciar
        while(contador < 10)
        {
            Debug.Log("Hola que tal " + contador);
            contador++;
        }

        bool miBooleana = false;
        while(miBooleana)
        {
            Debug.Log(miBooleana);
        }

        do
        {
            Debug.Log("Do while: " + miBooleana);
        } while (miBooleana);
        */


        //Arreglos

        int[] miArreglo = new int[7]; //Son inmutables
        string[] diasSemana = new string[7]
            {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};
        /*Debug.Log(diasSemana[0]);*/
        /*Debug.Log(diasSemana[1]);*/
        /*Debug.Log(diasSemana[2]);*/
        /*Debug.Log(diasSemana[3]);*/
        /*Debug.Log(diasSemana[4]);*/
        /*Debug.Log(diasSemana[5]);*/
        /*Debug.Log(diasSemana[6]);*/

        
        for(int i = 0; i < diasSemana.Length; i++)
        {
            miArreglo[i] = i + 1;
            //Debug.Log( miArreglo[i] + " " + diasSemana[i]);
        }
        

        Debug.Log("Ciclo foreach");
        foreach(int i in miArreglo)
        {
            
            Debug.Log(i);
        }
        foreach(string dia in diasSemana)
        {
            Debug.Log(dia);
        }

        //Arreglo bidimensional
        int[,] miMatriz = new int[3, 3]
            { {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
            };

        //Debug.Log("Matriz");
        //for(int i = 0; i < miMatriz.GetLength(0); i++)
        //{
        //    for(int j = 0; j < miMatriz.GetLength(1); j++)
        //    {
        //        Debug.Log(miMatriz[i,j]);
        //    }
        //}

        ////Arreglos Jagged
        //int[][] miArregloJagged = new int[][] //No te piden la segunda dimension
        //{
        //    new int[]{1, 2, 3},
        //    new int[]{4, 5},
        //    new int[]{6, 7, 8, 9}
        //};

        //miArregloJagged[1] = new int[] { 10, 11, 12, 13 };
        //Debug.Log(miArregloJagged[0][1]);

        //for(int x = 0; x < miArregloJagged.Length; x++)
        //{
        //    for(int y = 0; y < miArregloJagged[x].Length; y++)
        //    {
        //        Debug.Log(miArregloJagged[x][y]);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //contador++;
        //Debug.Log(contador);
    }
}
