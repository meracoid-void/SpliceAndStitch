using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private Color _baseColor;
    [SerializeField]
    private Color _offsetColor;
    [SerializeField]
    private Color _eventColor;
    [SerializeField]
    private Color _startingColor;
    [SerializeField]
    private Color _endingColor;

    [SerializeField]
    private SpriteRenderer _renderer;

    [SerializeField] 
    private GameObject _highlight;

    public void Init(bool isOffset)
    {
        if (isOffset)
        {
            Debug.Log($"Will be offset color ${_offsetColor.ToString()}");
            _renderer.color = _offsetColor;
        }
        else
        {
            Debug.Log($"Will be base color ${_baseColor.ToString()}");
            _renderer.color = _baseColor;
        }
    }

    public void SetEventColor()
    {
        _renderer.color = _eventColor;
    }

    public void SetEndingColor()
    {
        _renderer.color = _endingColor;
    }

    public void SetStartingColor()
    {
        _renderer.color = _startingColor;
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
