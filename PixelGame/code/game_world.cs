using Godot;
using System;
using System.ComponentModel;

public partial class game_world : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var music = GetNode<AudioStreamPlayer>("BackgroundMusic");
		music.Stream = GD.Load<AudioStream>("res://sound/music/youre my heart.ogg");
		music.Play();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void _on_background_music_finished()
	{
	
	}
}

