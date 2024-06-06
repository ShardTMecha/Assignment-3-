using Raylib_cs;
using System;
using System.Numerics;



    // Rectangle properties
public class LevelObjects
{

    

    public bool CheckCollision(float RectangleX, float RectangleY, float rectangleWidth, float rectangleHeight)
    {
       return Raylib.CheckCollisionRectangle(new Vector2(RectangleX, RectangleY), rectangleWidth,rectangleHeight);
    }

    public void Draw()
    {
       Raylib.DrawRectangle(0,50,20,800, Color.Blue);
       Raylib.DrawRectangle(500,600,500,20, Color.Blue);
       Raylib.DrawRectangle(400,600,500,20, Color.Blue);
    }


}
