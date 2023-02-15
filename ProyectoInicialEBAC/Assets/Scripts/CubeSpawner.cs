using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabCubo; //Prefab del cubo
    public List<GameObject> listaDeCubos; //Lista de cubos instanciados
    public float factorDeEscalamiento; //Porcentaje de reducción de tamaño de los cubos
    public int numCubos = 0; //Cantidad de cubos instanciados

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>(); //Inicializar lista de cubos
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++; //Aumentar número de cubos
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo); //Instanciar cubo
        tempGameObject.name = "CuboNumero " + numCubos; //Cambiarle el nombre al cubo creado
        Color c = new Color(Random.value, Random.value, Random.value); //Declarar color para el nuevo cubo
        tempGameObject.GetComponent<MeshRenderer>().material.color = c; //Asignar color al nuevo cubo

        tempGameObject.transform.position = Random.insideUnitSphere; //Invocar el cubo en una posición con un radio de 0 a 1

        listaDeCubos.Add(tempGameObject); //Agregar cubo a la lista
        List<GameObject> objetosParaEliminar = new List<GameObject>(); //Lista temporal de cubos a eliminar

        foreach(GameObject go in listaDeCubos) 
        {
            float scale = go.transform.localScale.x; //Obtener escala del cubo
            scale *= factorDeEscalamiento; //Obtener escala con el factor de escalamiento
            go.transform.localScale = Vector3.one * scale; //Multiplicar escala del cubo con la escala para reducir tamaño

            if(scale <= 0.1)
            {
                objetosParaEliminar.Add(go); //Agregar cubos a eliminar
            }
        }

        foreach(GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go); //Eliminar cubo a destruir de la lista de cubos 
            Destroy(go); //Destruir cubo
        }
    }
}
