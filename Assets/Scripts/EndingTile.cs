using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingTile : Tile
{

    [SerializeField]
    private Color _endingColor;

    public void Init()
    {
        _renderer.color = _endingColor;
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
