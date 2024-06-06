﻿namespace Assignment_3
{

    using Raylib_cs;
    using System.Numerics;
    using static LevelObject;

    public class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title"; // Window title
        static int screenWidth = 800; // Screen width
        static int screenHeight = 600; // Screen height
        static int targetFps = 60; // Target frames-per-second

        // Add class variables
        static Player player;
        static LevelObject levelObject;

        static void Main()
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(screenWidth, screenHeight, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(targetFps);
            // Setup your game. This is a function YOU define.
            Setup();
            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.RayWhite);
                // Your game code here. This is a function YOU define.
                Update();

                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            // Your one-time setup code here
            player = new Player(100, 100, 50, 50);

            //
            levelObject = new LevelObject(0, 550, 800, 50);
        }

        static void Update()
        {
            // Your game code run each frame here
            player.Update();

            levelObject.Draw();

            bool isColliding = levelObject.CheckCollision(player);
            if (isColliding)
            {
                // do stuff
            }
            Raylib.DrawText($"Is colliding? {isColliding}", 5, 5, 32, Color.Black);
        }

    }
}