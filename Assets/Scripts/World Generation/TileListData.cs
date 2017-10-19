using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileListData : MonoBehaviour {

    private static int MAP_SIZE = 100;
    private GameObject[,] tileArray;

    public void init()
    {
        if(tileArray == null)
        {
            tileArray = new GameObject[MAP_SIZE, MAP_SIZE];
        }
    }

    public GameObject getTileAtLocation(Vector2Int location)
    {
        return tileArray[location.x, location.y];
    }
    
    public GameObject[,] getTileArray()
    {
        return tileArray;
    }
    public int getMapSize()
    {
        return MAP_SIZE;
    }

    public void setTileAtLocation(Vector2Int location, GameObject mapTile)
    {
        if(tileArray == null)
        {
            init();
        }
        tileArray[location.x,location.y] = mapTile;
    }
}
