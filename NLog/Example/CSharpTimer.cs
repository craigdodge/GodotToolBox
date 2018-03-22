using Godot;
using System;

public class CSharpTimer : Timer
{
    public void onCSharpTimerTimout()
    {
        Log logNode = (Log)GetNode("../Log");
        logNode.Logger.Info("Hello from CSharpTimer!");
    }
}



