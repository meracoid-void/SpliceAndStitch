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

            text.text = $"Move {randomNum}";
            textGame.SetActive(true);
            player.moveDistance = randomNum;
        }
    }
}
