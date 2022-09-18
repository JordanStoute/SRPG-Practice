using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
    public Material defaultMaterial;
    public Material selectedMaterial;
    public GameManager gameManager;
    public GameObject cursor;
    public GameObject mainPlayer;

    public int mStart;
    public int nStart;

    private int m; // Number of rows
    private int n; // Number of columns
    private Transform[,] grid;
    private int[] currentIndex;
    //private int[] lastIndex;

    public int[] CurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            currentIndex = value;
        }
    }
    /*public int[] LastIndex
    {
        get
        {
            return lastIndex;
        }
        set
        {
            lastIndex = value;
        }
    }*/

    public Transform[,] Grid
    {
        get
        {
            return grid;
        }
    }

    void Start()
    {
        SetGrid();
        currentIndex = new int[] { mStart, nStart };
        //lastIndex = new int[] { mStart, nStart };
        SetMaterial(currentIndex, selectedMaterial);

        cursor.transform.position = new Vector3(grid[mStart, nStart].position.x, grid[mStart, nStart].position.y + gameManager.cursorHeight, grid[mStart, nStart].position.z);
        mainPlayer.transform.position = new Vector3(grid[mStart, nStart].position.x, grid[mStart, nStart].position.y + gameManager.unitHeight, grid[mStart, nStart].position.z);
    }

    void SetGrid()
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
    }

    public Material GetMaterial(int[] x)
    {
        return grid[x[0], x[1]].gameObject.GetComponent<Renderer>().material;
    }

    public void SetMaterial(int[] x, Material material)
    {
        grid[x[0], x[1]].gameObject.GetComponent<Renderer>().material = material;
    }
}
