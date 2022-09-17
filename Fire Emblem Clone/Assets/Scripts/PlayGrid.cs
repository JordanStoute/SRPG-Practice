using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    private int m; // Number of rows
    private int n; // Number of columns
    private Transform[,] grid;

    // Start is called before the first frame update
    void Start()
    {
        m = transform.childCount;
        n = transform.GetChild(0).childCount;
        grid = new Transform[m, n];

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                grid[i, j] = transform.GetChild(i).GetChild(j);
            }
        }

        Debug.Log(grid);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
