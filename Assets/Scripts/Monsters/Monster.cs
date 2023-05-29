using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Monsters
{
    public class Monster
    {
        public MonsterBase Base { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        public List<Move> Moves { get; set; }

        public Monster(MonsterBase monsterBase, int level)
        {
            Base = monsterBase;
            Level = level;
            HP = MaxHp;
            Moves = new List<Move>();
            foreach (var move in Base.LearnableMoves)
            {
                if (move.Level <= level)
                {
                    Moves.Add(new Move(move.MoveBase, 0));
                }

                if (Moves.Count >= 4)
                {
                    break;
                }
            }
        }

        public int Attack
        {
            get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
        }

        public int Defense
        {
            get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
        }

        public int SpAttack
        {
            get { return Mathf.FloorToInt((Base.SpAttack * Level) / 100f) + 5; }
        }

        public int SpDefense
        {
            get { return Mathf.FloorToInt((Base.SpDefense * Level) / 100f) + 5; }
        }

        public int Speed
        {
            get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5; }
        }

        public int MaxHp
        {
            get { return Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 10; }
        }
    }
}
