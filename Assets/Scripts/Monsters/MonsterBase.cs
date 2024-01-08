using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Monsters
{
    [CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create new Monster")]
    public class MonsterBase : ScriptableObject
    {
        [SerializeField]
        string monsterName;
        [TextArea]
        [SerializeField]
        string description;

        //Base Stats
        [SerializeField]
        int maxHp;
        [SerializeField]
        int attack;
        [SerializeField]
        int defense;
        [SerializeField]
        int spAttack;
        [SerializeField]
        int spDefense;
        [SerializeField]
        int speed;

        [SerializeField]
        List<LearnableMoves> learnableMoves;

        public string MonsterName
        {
            get { return monsterName; }
        }

        public string Description
        {
            get { return description; }
        }
        public int MaxHp
        {
            get { return maxHp; }
        }

        public int Attack
        {
            get { return attack; }
        }

        public int Defense
        {
            get { return defense; }
        }

        public int SpAttack
        {
            get { return spAttack; }
        }

        public int SpDefense
        {
            get { return spDefense; }
        }

        public int Speed
        {
            get { return speed; }
        }

        public List<LearnableMoves> LearnableMoves
        {
            get { return learnableMoves; }
        }
    }

    [System.Serializable]
    public class LearnableMoves
    {
        [SerializeField]
        MoveBase moveBase;

        [SerializeField]
        int level;

        public MoveBase MoveBase
        {
            get { return moveBase; }
        }

        public int Level
        {
            get { return level; }
        }
    }
}
