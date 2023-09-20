using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealFinish : MonoBehaviour
{
    public int cantidadObjetosNecesarios1 = 5;  // Cantidad de objetos para la escena 1
    public int cantidadObjetosNecesarios2 = 10; // Cantidad de objetos para la escena 2
    public string escena1;
    public string escena2;
    public string escenaFinal;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int cantidadEncontrada = GameObject.FindGameObjectsWithTag("Collectible").Length;

            if (cantidadEncontrada <= cantidadObjetosNecesarios1)
            {
                SceneManager.LoadScene(escena1);
            }
            else if (cantidadEncontrada <= cantidadObjetosNecesarios2)
            {
                SceneManager.LoadScene(escena2);
            }
            else
            {
                SceneManager.LoadScene(escenaFinal);
            }
        }
    }
}
