using Godot;
using System;

public partial class Node2D : Godot.Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	// Quits the game
	}
	private void _on_quit_pressed()
	{
	GetTree().Quit();
	}
	// Starts the game
	private void _on_play_pressed()
	{
	GetTree().ChangeSceneToFile("res://game_world.tscn");
	}
}