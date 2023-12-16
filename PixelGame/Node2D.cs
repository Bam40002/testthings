using Godot;
using System;

public partial class Node2D : Godot.Node2D
{
	public override void _Ready()
	{
		var music = GetNode<AudioStreamPlayer>("TitleMusic");
		music.Stream = GD.Load<AudioStream>("res://sound/music/Unreal_Superhero.ogg");
		music.Play();
	}
	// Quits the game
	private void _on_quit_pressed()
	{
	GetTree().Quit();
	}
	// Starts the game
	private void _on_play_pressed()
	{
		var music = GetNode<AudioStreamPlayer>("TitleMusic");
		music.Stop();
		GetTree().ChangeSceneToFile("res://game_world.tscn");
	}
}
