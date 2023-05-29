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
    }

    public void ChangeTile(Tile tile, bool didChange)
    {
        if (didChange)
        {
            currentTile.isPlayerEnter = false;
            currentTile = tile;
            _textObj.SetActive(false);
            if( currentTile is EventTile)
            {
                // Start a random event for the level
                Debug.Log("Start random event");
            }
            else if(currentTile is EndingTile)
            {
                // Start ending fight
                Debug.Log("Start End Fight");
            }
            else
            {
                if(Random.Range(0, 3) == 0)
                {
                    // Start Random Encounter
                    Debug.Log("Start Random Encounter");
                }
            }
        }
    }


}
