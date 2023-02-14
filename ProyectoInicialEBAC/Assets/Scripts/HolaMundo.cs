using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola Mundo desde Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Hola Mundo desde Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Hola Mundo desde Update cada frame");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola Mundo desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Hola Mundo desde LateUpdate al final del frame");
    }

    private void OnEnable()
    {
        Debug.LogError("Hola Mundo desde función OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("Hola Mundo desde función OnDisable");
    }
}
