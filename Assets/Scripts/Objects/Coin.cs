using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float rotationSpeed = 50.0f;

    AudioSource coin;

    private void Start()
    {
        coin = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TextManager textManager = FindObjectOfType<TextManager>();

            gameObject.GetComponent<MeshRenderer>().enabled = false;

            coin.Play();

            textManager.AddScore(10);
            Destroy(gameObject,1f);
        }
    }
}