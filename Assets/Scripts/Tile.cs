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

    public bool isPlayerEnter;

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
        isPlayerEnter = false;
    }

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    private void OnMouseDown()
    {
        var player = (Player)FindObjectOfType(typeof(Player));
        var manager = (PlayerManager)FindObjectOfType(typeof(PlayerManager));
        bool isMove = player.MovePlayer(this.transform.position);
        this.isPlayerEnter = isMove;
        Debug.Log(this.GetType().Name);
        manager.ChangeTile(this, isMove);
    }

}
