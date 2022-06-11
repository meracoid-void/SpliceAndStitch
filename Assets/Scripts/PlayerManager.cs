using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    [SerializeField]
    private GameObject _textObj;

    private Tile currentTile = null;

    public void Init()
    {
        currentTile = (StartingTile)FindObjectOfType(typeof(StartingTile));
        Debug.Log(currentTile.name);
    }

    public void ChangeTile(Tile tile, bool didChange)
    {
        if (didChange)
        {
            currentTile.isPlayerEnter = false;
            currentTile = tile;
            _textObj.SetActive(false);
        }
    }


}
