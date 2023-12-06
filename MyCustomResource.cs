using Godot;
using System;

[GlobalClass]
public partial class MyCustomResource : Resource
{
    [Export]
    public string Message { get; private set; }
}
