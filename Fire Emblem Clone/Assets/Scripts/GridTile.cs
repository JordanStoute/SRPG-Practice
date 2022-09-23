using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Material GetMaterial()
    {
        return gameObject.GetComponent<Renderer>().material;
    }

    public void SetMaterial(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }

    public Vector3 GetPosition()
    {
        return gameObject.transform.position;
    }
}
