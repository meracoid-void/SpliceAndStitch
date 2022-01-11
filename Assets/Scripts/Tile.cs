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
    public SpriteRenderer _renderer;

    [SerializeField] 
    public GameObject _highlight;

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

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

}
