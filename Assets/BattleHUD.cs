using Assets.Scripts.Monsters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField]
    Text nameText;
    [SerializeField]
    Text levelText;

    [SerializeField]
    HPBar hpBar;

    Monster _monster;

    public void SetData(Monster monster)
    {
        _monster = monster;

        nameText.text = monster.Base.MonsterName;
        levelText.text = "Lvl " + monster.Level;
        hpBar.SetHP((float)monster.HP / (float)monster.MaxHp);
    }

    public IEnumerator UpdateHP()
    {
        yield return hpBar.SetHPSmooth((float)_monster.HP / (float)_monster.MaxHp);
    }
}
