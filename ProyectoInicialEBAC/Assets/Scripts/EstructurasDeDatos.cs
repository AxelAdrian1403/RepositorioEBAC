using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>(); //No permite repetir elementos y no está ordenada
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }

        listaNumeros.Sort(); //Se ordenan los numeros de la Lista

        listaStrings.Add("Diego");
        listaStrings.Add("Sofia");
        listaStrings.Add("Daniel");
        listaStrings.Add("Javier");
        listaStrings.Add("Diana");

        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }

        //Eliminar nombre de lista
        listaStrings.Remove("Javier");
        listaStrings.Remove("Diego");
        listaStrings.RemoveAt(0); //Se la pasa su index
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }

    public void DemoHashSet()
    {
        for(int i = 0; i < 20; i++)
        {
            hashSetInts.Add(i);
        }

        if(hashSetInts.Contains(5))
        {
            hashSetInts.Remove(5);
            foreach(var numero in hashSetInts)
            {
                Debug.Log(numero);
            }
        }
        else
        {
            Debug.Log("El HashSet no contiene se elemento");
        }

    }

    public void DemoQueue()
    {
        //FIFO First In First Out
        colaStrings.Enqueue("Proyectil 1"); //Agregar contenido
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");

        Debug.Log(colaStrings.Peek()); //Mostrar primer elemento
        colaStrings.Dequeue(); //Eliminar primer elemento

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();

        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();

        Debug.Log(colaStrings.Peek());
        Debug.Log(colaStrings.Peek());
        Debug.Log(colaStrings.Peek());
    }

    public void DemoStack()
    {
        pilaStrings.Push("As"); //Agregar elemento a la pila
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");

        Debug.Log(pilaStrings.Peek()); //Mostrar elemento
        pilaStrings.Pop(); //Eliminar elemento

        Debug.Log(pilaStrings.Peek()); //Mostrar elemento
        pilaStrings.Pop(); //Eliminar elemento
        Debug.Log(pilaStrings.Peek()); //Mostrar elemento
        pilaStrings.Pop(); //Eliminar elemento
        Debug.Log(pilaStrings.Peek()); //Mostrar elemento
        pilaStrings.Pop(); //Eliminar elemento
    }

    public void DemoDictionary()
    {
        float temporal = 0;
        poderArmas.Add("Rifle", 7.0f);
        poderArmas.Add("Pistola", 3.0f);
        poderArmas.Add("Escopeta", 5.0f);
        poderArmas.Add("RifleFrancotirador", 10.0f);
        poderArmas.Add("Cuchillo", 2.0f);

        Debug.Log(poderArmas["Escopeta"]); //Se pone la llave que se quiere
        
        if(poderArmas.TryGetValue("Escopeta", out temporal))
        {
            Debug.Log(poderArmas["Escopeta"] + ":)");
        }
        else
        {
            Debug.Log("El arma no existe");
        }

        poderArmas.ContainsKey("Escopeta");
    }
}
