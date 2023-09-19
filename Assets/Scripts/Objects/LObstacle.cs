using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LObstacle : MonoBehaviour
{
    float velocidad = 0.5f; // La velocidad a la que se moverá el objeto
    float distancia = 10.0f; // La distancia total que recorrerá el objeto

    private Vector3 inicioPosicion;
    private Vector3 objetivoPosicion;

    void Start()
    {
        inicioPosicion = transform.position;
        objetivoPosicion = transform.position + Vector3.left * distancia;
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * velocidad, 1.0f);
        transform.position = Vector3.Lerp(inicioPosicion, objetivoPosicion, t);
    }
}
