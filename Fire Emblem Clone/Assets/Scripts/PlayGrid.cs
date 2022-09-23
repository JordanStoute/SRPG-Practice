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
    private GridTile[,] gTiles;
    private int[] currentIndex;

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

    public GridTile[,] GTiles
    {
        get
        {
            return gTiles;
        }
    }

    void Start()
    {
        SetGrid();
        currentIndex = new int[] { mStart, nStart };
        SetMaterial(currentIndex, selectedMaterial);

        cursor.transform.position = new Vector3(gTiles[mStart, nStart].GetPosition().x, gTiles[mStart, nStart].GetPosition().y + gameManager.cursorHeight, gTiles[mStart, nStart].GetPosition().z);
        mainPlayer.transform.position = new Vector3(gTiles[mStart, nStart].GetPosition().x, gTiles[mStart, nStart].GetPosition().y + gameManager.unitHeight, gTiles[mStart, nStart].GetPosition().z);
    }

    void SetGrid()
    {
        m = transform.childCount;
        n = transform.GetChild(0).childCount;
        gTiles = new GridTile[m, n];

        for (int i = 0; i < gTiles.GetLength(0); i++)
        {
            for (int j = 0; j < gTiles.GetLength(1); j++)
            {
                gTiles[i, j] = transform.GetChild(i).GetChild(j).GetComponent<GridTile>();
            }
        }
    }

    public Material GetMaterial(int[] x)
    {
        return gTiles[x[0], x[1]].GetMaterial();
    }

    public void SetMaterial(int[] x, Material material)
    {
        gTiles[x[0], x[1]].SetMaterial(material);
    }
}
