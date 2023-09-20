using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealFinish : MonoBehaviour
{
    TextManager textManager;

    string VictoriaBronze = "VictoriaB";
    string VictoriaSilver = "VictoriaS";
    string VictoriaGold = "VictoriaG";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (textManager.score >= 250)
            {
                SceneManager.LoadScene(VictoriaGold);
            }
            if (textManager.score >= 150)
            {
                SceneManager.LoadScene(VictoriaSilver);
            }
            else
            {
                SceneManager.LoadScene(VictoriaBronze);
            }
        }
    }
}