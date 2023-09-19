using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia al objeto del jugador que seguirá la cámara
    public float smoothSpeed = 0.125f; // Velocidad de suavizado de la cámara

    private Vector3 offset; // Distancia entre la cámara y el jugador

    void Start()
    {
        offset = transform.position - target.position; // Calcula la distancia inicial entre la cámara y el jugador
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calcula la posición deseada de la cámara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Aplica suavizado a la posición de la cámara
        transform.position = smoothedPosition; // Actualiza la posición de la cámara
    }
}
