using Raylib_cs;
using System;
using System.Numerics;

public class Player
{
    // Circle properties
    public Rectangle bounds;
    float speed = 5.0f;

    public Player(int x, int y, int w, int h)
    {
        bounds = new Rectangle(x, y, w, h);
    }

    public void Update()
    {
        // Move
        if (Raylib.IsKeyDown(KeyboardKey.D)) bounds.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.A)) bounds.X -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.W)) bounds.Y -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.S)) bounds.Y += speed;

        // Draw
        Raylib.DrawRectangleRec(bounds, Color.Black);
    }
}
