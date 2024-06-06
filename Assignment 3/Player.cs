using Raylib_cs;
using System;
using System.Numerics;

public class Player
{
    static void PLayer(string[] args)
    {


        // Circle properties
        float RectangleX = 400;
        float RectangleY = 300;
    
        float speed = 5.0f;

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Update
            if (Raylib.IsKeyDown(KeyboardKey.D)) RectangleX += speed;
            if (Raylib.IsKeyDown(KeyboardKey.A)) RectangleX -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.W)) RectangleY -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.S)) RectangleY += speed;

            // Draw

            Raylib.ClearBackground(Color.RayWhite);

            Raylib.DrawRectangle((int)RectangleX, (int)RectangleY,50,50, Color.Red);


        }

        


    }
}

