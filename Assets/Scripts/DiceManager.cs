using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;
    [SerializeField]
    GameObject textGame;
    public void RollDice()
    {
        var player = (Player)FindObjectOfType(typeof(Player));
        if (player.moveDistance == 0)
        {
            int randomNum = Random.Range(1, 7);

            if(randomNum == 1)
            {
                text.text = $"Move 1 Space";
            }
            else
            {
                text.text = $"Move 1 - {randomNum} Spaces";
            }
            textGame.SetActive(true);
            player.moveDistance = randomNum;
        }
    }
}
