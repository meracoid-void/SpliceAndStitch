using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Monsters
{
    [CreateAssetMenu(fileName = "Move", menuName = "Monster/Create new move")]
    public class MoveBase : ScriptableObject
    {
        [SerializeField]
        string _name;

        [TextArea]
        [SerializeField]
        string _description;

        [SerializeField]
        int _power;

        [SerializeField]
        int _accuracy;

        [SerializeField]
        int _ap;

        [SerializeField]
        MonsterType _type;

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public int Power
        {
            get { return _power; }
        }

        public int Accuracy
        {
            get { return _accuracy; }
        }

        public int AP
        {
            get { return _ap; }
        }

        public MonsterType Type
        {
            get { return _type; }
        }
    }
}
