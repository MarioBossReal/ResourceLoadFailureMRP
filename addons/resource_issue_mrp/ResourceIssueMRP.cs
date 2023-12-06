#if TOOLS
using Godot;
using System;

[Tool]
public partial class ResourceIssueMRP : EditorPlugin
{
	public override void _EnterTree()
	{
		GD.Print("Plugin Loaded.");
		GD.Print("Attempting to load res://my_resource_instance.res as type MyCustomResource from an EditorPlugin...");

		var resource = GD.Load("res://my_resource_instance.res");

		if (resource != null && resource is MyCustomResource custom)
		{
			GD.Print(custom.Message);
		}
		else
		{
			GD.Print("Failed!");
		}
	}

	public override void _ExitTree()
	{
        GD.Print("Plugin Unloaded");
    }
}
#endif
