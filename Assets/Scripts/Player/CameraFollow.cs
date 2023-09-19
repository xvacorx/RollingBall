using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia al objeto del jugador que seguir� la c�mara
    public float smoothSpeed = 0.125f; // Velocidad de suavizado de la c�mara

    private Vector3 offset; // Distancia entre la c�mara y el jugador

    void Start()
    {
        offset = transform.position - target.position; // Calcula la distancia inicial entre la c�mara y el jugador
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // Calcula la posici�n deseada de la c�mara
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Aplica suavizado a la posici�n de la c�mara
        transform.position = smoothedPosition; // Actualiza la posici�n de la c�mara
    }
}
