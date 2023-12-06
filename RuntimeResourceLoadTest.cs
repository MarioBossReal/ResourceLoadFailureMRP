using Godot;
using System;

public partial class RuntimeResourceLoadTest : Node
{
    [Export]
    public Resource AnyType { get; private set; }

    [Export]
    public string ResourcePath { get; private set; }

    public override void _Ready()
    {
        GD.Print("Attempting to cast from Resource to MyCustomResource during runtime...");

        if (AnyType != null && AnyType is MyCustomResource custom)
            GD.Print(custom.Message);
        else
            GD.Print("Failed!");

        GD.Print("Attempting to load resource from disk as MyCustomResource during runtime...");

        var resource = GD.Load(ResourcePath);

        if (resource != null && resource is MyCustomResource custom2)
            GD.Print(custom2.Message);
        else 
            GD.Print("Failed!");
    }
}
