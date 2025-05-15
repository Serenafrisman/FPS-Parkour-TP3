using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonarCubo : MonoBehaviour
{
    public GameObject CuboPrefab;

    void Start()
    {
        Clonar(); // Llamás al método con el nuevo nombre
    }

    void Update()
    {
        
    }

    void Clonar() // Cambiaste el nombre del método
    {
        Instantiate(CuboPrefab);
    }
}
