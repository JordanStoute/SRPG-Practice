using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    private int m; // Number of rows
    private int n; // Number of columns
    private int[,] grid;

    // Start is called before the first frame update
    void Start()
    {
        m = transform.childCount;
        n = transform.GetChild(0).childCount;
        grid = new int[m, n];
        Debug.Log("Number of rows: " + m + "\nNumber of columns: " + n);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
