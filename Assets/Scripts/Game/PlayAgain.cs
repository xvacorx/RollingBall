using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    // Publica una variable para almacenar el nombre de la escena que deseas cargar
    public string nombreDeLaEscenaARecargar;

    // Este método se llama cuando el botón es presionado
    public void CargarLaEscena()
    {
        // Cargar la escena utilizando el nombre proporcionado
        SceneManager.LoadScene(nombreDeLaEscenaARecargar);
    }
}
