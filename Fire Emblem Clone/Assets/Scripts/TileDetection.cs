using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetection : MonoBehaviour
{
    [SerializeField] Material selectedMaterial;
    [SerializeField] Material defaultMaterial;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Tile")
        {
            collision.gameObject.GetComponent<Renderer>().material = selectedMaterial;
        }
            Debug.Log("Enter works!");
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Tile")
        {
            collision.gameObject.GetComponent<Renderer>().material = defaultMaterial;
        }
    }
}
