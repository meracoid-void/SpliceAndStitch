using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Monsters
{
    public class Move
    {
        public MoveBase Base { get; set; }
        public int AP { get; set; }
        public int Proficiency { get; set; }

        public Move(MoveBase _base, int proficiency)
        {
            Base = _base;
            AP = _base.AP;
            Proficiency = proficiency;
        }
    }
}
