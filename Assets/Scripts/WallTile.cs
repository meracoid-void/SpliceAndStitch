using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class WallTile : Tile
    {

        [SerializeField]
        private Color _startingColor;

        public void Init()
        {
            _renderer.color = _startingColor;
            isObstacle = true;
        }


        private void OnMouseEnter()
        {
            _highlight.SetActive(true);
        }

        private void OnMouseExit()
        {
            _highlight.SetActive(false);
        }
    }
}
