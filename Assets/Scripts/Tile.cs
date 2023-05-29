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

    public bool isObstacle;

    public void Init(bool isOffset)
    {
        if (isOffset)
        {
            _renderer.color = _offsetColor;
        }
        else
        {
            _renderer.color = _baseColor;
        }
        isPlayerEnter = false;
        isObstacle = false;
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
        manager.ChangeTile(this, isMove);
    }

}
