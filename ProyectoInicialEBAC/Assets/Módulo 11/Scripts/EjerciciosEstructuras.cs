using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    //Ejercicio 1
    List<int> listaNumeros = new List<int>();

    //Ejercicio 2
    int[] arregloNumeros = new int[5] { 4, 2, 1, 5, 3 };

    //Ejercicio 3
    List<int> listaParaHashset = new List<int>() {1, 1, 2, 2, 2, 3, 4, 4, 5, 6, 6};

    //Ejercicio 4
    Stack<string> pilaNombres = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {
        CrearLista(5, 6, 11);

        int[] arregloOrdenado = ArregloDescendente(arregloNumeros);
        Debug.Log("ARREGLO DESCENDENTE");
        foreach(int i in arregloOrdenado)
        {
            Debug.Log(i);
        }

        HashSet<int> hash = RegresarHashSet(listaParaHashset);
        Debug.Log("NUEVO HASH");
        foreach (int i in hash)
        {
            Debug.Log(i);
        }
        Debug.Log(hash.Count());

        pilaNombres.Push("Adrian");
        pilaNombres.Push("Luis");
        pilaNombres.Push("Karla");
        pilaNombres.Push("Andrea");
        pilaNombres.Push("Javier");
        CrearCola(pilaNombres);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CrearLista(int tam, int rangoInf, int rangoSup)
    {
        for(int i = 0; i < tam; i++)
        {
            listaNumeros.Add(UnityEngine.Random.Range(rangoInf, rangoSup));
        }

        Debug.Log("LISTA NUMEROS ALEATORIOS");
        foreach(int num in listaNumeros)
        {
            Debug.Log(num);
        }
    }

    public int[] ArregloDescendente(int[] arreglo)
    {
        Array.Sort(arreglo);
        Array.Reverse(arreglo);

        return arreglo;
    }

    public HashSet<int> RegresarHashSet(List<int> lista)
    {
        HashSet<int> hash = new HashSet<int>(lista.Distinct());

        return hash;
    }

    public void CrearCola(Stack<string> stack)
    {
        Queue<string> cola = new Queue<string>();

        Debug.Log("CONTENIDO STACK");
        while(stack.Count > 0)
        {
            Debug.Log(stack.Peek());
            cola.Enqueue(stack.Peek());
            stack.Pop();
        }

        Debug.Log("CONTENIDO QUEUE");
        while (cola.Count > 0)
        {
            Debug.Log(cola.Peek());
            cola.Dequeue();
        }

    }
}
