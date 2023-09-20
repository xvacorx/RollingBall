using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    private Button boton;

    private void Start()
    {
        // Obtener la referencia al componente Button del botón
        boton = GetComponent<Button>();

        // Agregar un listener al evento de clic del botón
        boton.onClick.AddListener(CargarEscenaTutorial);
    }

    private void CargarEscenaTutorial()
    {
        // Cargar la escena "Tutorial" cuando se hace clic en el botón
        SceneManager.LoadScene("Tutorial");
    }
}
