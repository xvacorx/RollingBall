using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RealGameManager : MonoBehaviour
{
    public int maxFalls = 3; 
    private int currentFalls = 0;
    public Transform playerTransform;
    public Transform respawnPoint; 
    private Rigidbody playerRigidbody;

    public string nextSceneName;

    private void Start()
    {
        ResetPlayerPosition();
        playerRigidbody = playerTransform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (playerTransform.position.y < -10f)
        {
            currentFalls++;

            if (currentFalls >= maxFalls)
            {
                LoadNextScene();
            }
            else
            {
                ResetPlayerPosition();
            }
        }
    }

    private void ResetPlayerPosition()
    {
        playerTransform.position = respawnPoint.position;

        TextManager textManager = FindObjectOfType<TextManager>();

        textManager.LoseLife(1);

        if (playerRigidbody != null)
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
