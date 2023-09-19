using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int maxFalls = 3; // N�mero m�ximo de ca�das permitidas.
    private int currentFalls = 0; // N�mero de ca�das actuales.
    public Transform playerTransform; // Referencia al transform del jugador.
    public Transform respawnPoint; // Referencia al punto de reaparici�n.
    private Rigidbody playerRigidbody; // Referencia al Rigidbody del jugador.

    private void Start()
    {
        // Establece la posici�n inicial del jugador en el punto de reaparici�n.
        ResetPlayerPosition();
        playerRigidbody = playerTransform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Verifica si la posici�n Y del jugador es menor que -10.
        if (playerTransform.position.y < -10f)
        {
            currentFalls++;

            if (currentFalls >= maxFalls)
            {
                // Si el jugador ha ca�do m�s veces de las permitidas, reinicia el nivel.
                RestartLevel();
            }
            else
            {
                // De lo contrario, simplemente reinicia la posici�n y el momento del jugador.
                ResetPlayerPosition();
            }
        }
    }

    private void ResetPlayerPosition()
    {
        // Coloca al jugador en el punto de reaparici�n.
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