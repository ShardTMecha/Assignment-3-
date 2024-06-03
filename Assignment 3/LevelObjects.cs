using Raylib_cs;
using System;

public class LevelObjects
{
	public LevelObjects()
	{
        Raylib.DrawRectangle(0, 580, 800, 20, Color.Red);
        Raylib.DrawRectangle(600, 0, 20, 500, Color.Red);
        Raylib.DrawRectangle(780, 0, 20, 500, Color.Red);
    }
}
