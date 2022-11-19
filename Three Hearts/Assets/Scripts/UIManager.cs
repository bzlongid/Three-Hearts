using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject home;
    [SerializeField] GameObject credits;

    Tilemap tilemap;
    public TileBase homeTile;
    public TileBase creditTile;

    void Start()
    {
        tilemap = FindObjectOfType<Tilemap>();
        SetHomeActive();
    }

    public void SetHomeActive()
    {
        home.SetActive(true);
        credits.SetActive(false);
        tilemap.SwapTile(creditTile, homeTile);
    }

    public void SetCreditsActive()
    {
        credits.SetActive(true);
        home.SetActive(false);
        tilemap.SwapTile(homeTile, creditTile);
    }
}
