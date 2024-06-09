using Raylib_cs;
using System;
using System.Numerics;

public class WinArea
{
    public Rectangle Bounds;


    public WinArea(int x, int y, int w, int h)
    {

        Bounds = new Rectangle(x, y, w, h);
    }

    public bool CheckCollision(Player player)
    {
        return Raylib.CheckCollisionRecs(this.Bounds, player.bounds);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(Bounds, Color.Black);

    }
}
