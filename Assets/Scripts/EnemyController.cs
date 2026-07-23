using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 3f;
    public float altura = 0.5f;
    
    private float posicionInicialY;

    void Start()
    {
        posicionInicialY = transform.position.y;
    }

    void Update()
    {
        float nuevaY = posicionInicialY + Mathf.Sin(Time.time * velocidad) * altura;
        
        transform.position = new Vector3(transform.position.x, nuevaY, transform.position.z);
    }
}
