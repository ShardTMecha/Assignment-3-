using Raylib_cs;
using System;

public class Player
{
    static void PLayer(string[] args)
    {


        // Circle properties
        float circleX = 400;
        float circleY = 300;
        float circleRadius = 20;
        float speed = 5.0f;

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Update
            if (Raylib.IsKeyDown(KeyboardKey.D)) circleX += speed;
            if (Raylib.IsKeyDown(KeyboardKey.A)) circleX -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.W)) circleY -= speed;
            if (Raylib.IsKeyDown(KeyboardKey.S)) circleY += speed;

            // Draw

            Raylib.ClearBackground(Color.RayWhite);

            Raylib.DrawCircle((int)circleX, (int)circleY, circleRadius, Color.Red);


        }



    }
}

