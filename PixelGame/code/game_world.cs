using Godot;
using System;
using System.ComponentModel;

public partial class game_world : Node2D
{
	// Pays music at the start
	public override void _Ready()
	{
		var music = GetNode<AudioStreamPlayer>("BackgroundMusic");
		music.Stream = GD.Load<AudioStream>("res://sound/music/youre my heart.ogg");
		music.Play();
	}
}

