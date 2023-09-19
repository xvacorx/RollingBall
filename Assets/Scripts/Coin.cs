using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float rotationSpeed = 50.0f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TextManager textManager = FindObjectOfType<TextManager>();

            textManager.AddScore(10);
            Destroy(gameObject);
        }
    }
}