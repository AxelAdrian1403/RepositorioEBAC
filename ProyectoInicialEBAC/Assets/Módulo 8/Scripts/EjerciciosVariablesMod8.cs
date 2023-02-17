using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    GameObject go;
    int entero = 0;
    int x = 1;
    float flotante = 1, num1 = 3.4F, num2 = 4.3F, y = 4.87452745F;
    string nombre = "Axel Adrian Flores Alvarez";
    string[] lista;
    

    // Start is called before the first frame update
    void Start()
    {
        
        go = this.gameObject;
        int resultado = (int)(num1 + num2);
        Debug.Log(resultado);

        string valor = y.ToString("0.####");
        Debug.Log(valor);

        string n1 = nombre.Substring(0, 12);
        string n2 = nombre.Substring(12, 7);
        string n3 = nombre.Substring(19, 7);

        Debug.Log(n1);
        Debug.Log(n2);
        Debug.Log(n3);

        lista = nombre.Split(' ');
        foreach(string p in lista)
        {
            Debug.Log(p);
        }

        string numero1 = "17050";
        string numero2 = "23480";
        int nume1 = 0, nume2 = 0, resultString = 0;

        if(int.TryParse(numero1, out nume1) && int.TryParse(numero2, out nume2))
        {
            resultString = nume1 + nume2;
            Debug.Log(resultString);
        }

        string saludo = "Hola Mundo";
        for(int i = 0; i < saludo.Length; i++)
        {
            if(i % 2 == 0)
            {
                Debug.Log(saludo[i]);
            }
        }

        string eliminarCaracter = "Hola Mundo";
        
        Debug.Log(eliminarCaracter.Remove(0, 5));

        string color = "verde";
        switch(color)
        {
            case "rojo":
                go.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "verde":
                go.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "amarillo":
                go.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case "morado":
                go.GetComponent<MeshRenderer>().material.color = Color.magenta;
                break;
            case "negro":
                go.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        entero++;
        Debug.LogWarning($"Entero = {entero}");
    }

    private void FixedUpdate()
    {
        flotante *= 2;
        Debug.LogError($"Flotante = {flotante}");

        
        if(x % 2 == 0)
        {
            go.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            go.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        x++;
    }
}
