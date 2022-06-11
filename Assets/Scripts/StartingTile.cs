using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingTile : Tile
{

    [SerializeField]
    private Color _startingColor;

    public void Init()
    {
        _renderer.color = _startingColor;
        this.isPlayerEnter = true;
    }


    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
