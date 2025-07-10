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
}
