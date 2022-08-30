namespace Models
{
    /// <summary>
    /// The type of terrain
    /// </summary>
    public enum TerrainType : int
    {
        OpenGrass = 0,
        OpenPasture = 1,
        RoadAsphalt = 2,
        RoadBrick = 3,
        House = 4,
        Church = 5,
        Sand = 6,
        HedgeRow = 7,
        WaterDeep = 8,
        WaterShallow= 9,        
        Mud = 10,
        MudShallow = 11,
        MudDeep = 12,

        //TODO: Make a terrain features class
        // battle field conditions start here        
        Duckboard = 14,        
        BunkerWood = 16,
        Crater = 18,
        Trench = 19,
        Pillbox = 20,
        Tunnel = 21,
        BunkerConcrete = 22,
    }
}