using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int maxFalls = 3; // Número máximo de caídas permitidas.
    private int currentFalls = 0; // Número de caídas actuales.
    public Transform playerTransform; // Referencia al transform del jugador.
    public Transform respawnPoint; // Referencia al punto de reaparición.
    private Rigidbody playerRigidbody; // Referencia al Rigidbody del jugador.

    private void Start()
    {
        // Establece la posición inicial del jugador en el punto de reaparición.
        ResetPlayerPosition();
        playerRigidbody = playerTransform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Verifica si la posición Y del jugador es menor que -10.
        if (playerTransform.position.y < -10f)
        {
            currentFalls++;

            if (currentFalls >= maxFalls)
            {
                // Si el jugador ha caído más veces de las permitidas, reinicia el nivel.
                RestartLevel();
            }
            else
            {
                // De lo contrario, simplemente reinicia la posición y el momento del jugador.
                ResetPlayerPosition();
            }
        }
    }

    private void ResetPlayerPosition()
    {
        // Coloca al jugador en el punto de reaparición.
        playerTransform.position = respawnPoint.position;

        TextManager textManager = FindObjectOfType<TextManager>();

        textManager.LoseLife(1);

        // Resetea la velocidad del Rigidbody del jugador a cero.
        if (playerRigidbody != null)
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }

    private void RestartLevel()
    {
        // Reinicia el nivel actual.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}