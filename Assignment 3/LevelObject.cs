using Raylib_cs;
using System;
using System.Numerics;

public class LevelObject
{
    // Variables
    public Rectangle bounds;
    
    // Constructor
    public LevelObject(int x, int y, int w, int h)
    {
        bounds = new Rectangle(x, y, w, h);
    }

    // Functions
    public bool CheckCollision(Player player)
    {
       return Raylib.CheckCollisionRecs(this.bounds, player.bounds);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(bounds, Color.Blue);
    }


}
