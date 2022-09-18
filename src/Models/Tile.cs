using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Tile
    {    
        /// <summary>
        /// An individual tile on map
        /// </summary>
        public Tile(int xCoordinate, int yCoordinate, int zCoordinate) { }

        /// <summary>
        /// Searchable Id of the Tile
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// X coordinate of the tile
        /// </summary>
        public int XCoordinate { get; set; }
        /// <summary>
        /// YCoordinate of the tile
        /// </summary>
        public int YCoordinate { get; set; }
        /// <summary>
        /// True if units are on the tile
        /// </summary>
        /// 
        public int ZCoordinate { get; set; }

        public bool UnitsOnTile { get; set; }
        /// <summary>
        /// Type of terrain the tile is
        /// </summary>
        public TerrainType Terrain { get; set; }
        /// <summary>
        /// Units on the tile
        /// </summary>
        public Unit[] Units { get; set; }
    }
}