using System;
using Godot;

public static class GodotExtensions
{ 
    // Replacement for rand_range GDScript function
    public static float FloatRange(this Random random, float min = 0.0f, float max = 1.0f)
    {
        return (float)(random.NextDouble() * (max - min) + min);
    }

    // Generic version of GetNode, with type conversion built in.
    public static T GetNode<T>(this Node node, NodePath Name) where T : Node
    {
        T n = (T)node.GetNode(Name);
        return n;
    }
}