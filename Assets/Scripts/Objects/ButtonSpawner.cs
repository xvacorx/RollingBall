using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    public GameObject ObjetoASpawnear;
    public GameObject ObjetoASpawfar;
    public GameObject Bridge;

    private void Start()
    {
        ObjetoASpawnear.GetComponent<CapsuleCollider>().enabled = false;
        ObjetoASpawfar.GetComponent<CapsuleCollider>().enabled = false;
        Bridge.GetComponent<MeshCollider>().enabled = false;

        ObjetoASpawnear.GetComponent<MeshRenderer>().enabled = false;
        ObjetoASpawfar.GetComponent<MeshRenderer>().enabled = false;
        Bridge.GetComponent <MeshRenderer>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObjetoASpawnear.GetComponent<CapsuleCollider>().enabled = true;
            ObjetoASpawfar.GetComponent<CapsuleCollider>().enabled = true;
            Bridge.GetComponent<MeshCollider>().enabled = true;

            ObjetoASpawnear.GetComponent<MeshRenderer>().enabled = true;
            ObjetoASpawfar.GetComponent<MeshRenderer>().enabled = true;
            Bridge.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
