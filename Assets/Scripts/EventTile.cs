using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTile : Tile
{

    [SerializeField]
    private Color _eventColor;

    public void Init()
    {
        _renderer.color = _eventColor;
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
