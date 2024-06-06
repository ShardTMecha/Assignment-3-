namespace Assignment_3
{

    using Raylib_cs;
    using System.Numerics;
    using static LevelObjects;

    public class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title"; // Window title
        static int screenWidth = 800; // Screen width
        static int screenHeight = 600; // Screen height
        static int targetFps = 60; // Target frames-per-second

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
        }

        static void Update()
        {
             bool CheckCollision(float RectangleX, float RectangleY, float rectangleWidth, float rectangleHeight)
            {
                return Raylib.CheckCollisionRecs(new Vector2(RectangleX, RectangleY);
            }

            static void Draw()
            {
                Raylib.DrawRectangle(0, 50, 20, 800, Color.Blue);
                Raylib.DrawRectangle(500, 600, 500, 20, Color.Blue);
                Raylib.DrawRectangle(400, 600, 500, 20, Color.Blue);
            }
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

                    Raylib.DrawRectangle((int)RectangleX, (int)RectangleY, 50, 50, Color.Red);


                }
                // Your game code run each frame here
            }
    }
}