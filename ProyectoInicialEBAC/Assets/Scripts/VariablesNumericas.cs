using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    //Byte --             [0 0 0 0 0 0 0 0]
    //Short --            [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Int --              [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Long --             [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    //Float --            [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Double --           [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongSinSigno = 200;



    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("El valor de miInt es: " + miInt);
        miByte = 0;
        miIntSinSigno = miByte;

        //Casteo
        miIntSinSigno = (uint)miByteConSigno; //Casteo explícito, pero puede causar problemas porque los datos con signo utilizan su última casilla para el valor del signo

        
        miLong = long.MaxValue; //Máximo valor que puede tomar el Long
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es: " + miInt);

        float a, b, c;
        float f;

        a = 5;
        b = 10;

        c = a + b;
        Debug.Log(c);

        c = a - b;
        Debug.Log(c);

        c = a * b;
        Debug.Log(c);

        f = a / b; //0.5, no importa si el resultado es un flotante, una operación de int no va a retornar un flotante

        Debug.Log(f);

        int x = 5, y = 10;

        miInt = Random.Range(x, y);

        if(miInt % 2 == 0)
        {
            Debug.Log("El numero " + miInt + " es par");
        }
        else
        {
            Debug.Log("El numero " + miInt + " es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        miShort += 3;
        //Debug.Log(miShort);

        miLong /= 2;
        Debug.Log(miLong);

        /*
         *  Operadores de incrmento y decremento
         *  += -= *= /=
         */
    }
}
