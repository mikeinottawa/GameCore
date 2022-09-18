using Models;
using System;
using Xunit;

namespace Tests
{
    public class TerrainTest
    {
        [Fact]
        public void UnitCantSeeOtherUnit()
        {
            var unit = new Unit();
            unit.CurrentTile = new Tile(1, 2, 1);
            var enemyUnit = new Unit();
            enemyUnit.CurrentTile = new Tile(2, 2, 4);

        }
    }
}