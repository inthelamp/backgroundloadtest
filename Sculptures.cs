using Godot;
using System;

public class Sculptures : Node2D
{
    public override void _Ready()
    {

    }
	
	public void OnSwitchPressed()
	{
		var sw = (Button) GetNode("switch");
		sw.Hide();
		var backgroundLoad = (BackgroundLoad)GetNode("/root/BackgroundLoad");	
		backgroundLoad.GoToScene("res://Paintings.tscn");
	}
}