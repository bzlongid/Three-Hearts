using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSwap : MonoBehaviour
{
    public TileBase tileA;
    public TileBase tileB;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Tilemap tilemap = GetComponent<Tilemap>();
            tilemap.SwapTile(tileA, tileB);
        }
    }
}
