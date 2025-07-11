using Godot;
using System;
using System.Transactions;

public partial class WorldGenTileMapLayer : TileMapLayer
{
    public override void _Ready()
    {
        
        foreach (var cell in GetUsedCells())
        {
            var tileData = GetCellTileData(cell);
            if (tileData != null)
            {

            }
        }
    }
    
    public override void _Draw()
    {
        var chunkRoot = GetNode("World/Chunks/Chunk_0_0"); // chemin vers un chunk
        var tileMapLayer = chunkRoot.GetNode<TileMapLayer>("TileMapLayer");

        
        foreach (var cell in GetUsedCells())
        {
            var tileData = GetCellTileData(cell);
            if (tileData != null)
            {
                
            }
        }
    }
}
