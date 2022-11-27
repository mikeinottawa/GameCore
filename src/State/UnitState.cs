using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace State
{
    public class UnitState
    {
        private Unit _unit { get; set; }
        private Tile CurrentTile { get; set; }

        public UnitState(Unit unit)
        {
            _unit = unit;
        }

        public void SetCurrentTile(Tile tile)
        {
            CurrentTile = tile;
        }
    }
}