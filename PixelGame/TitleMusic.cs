using Godot;
using System;

public partial class TitleMusic : Node
{
	public override void _Ready()
	{
		var music = GetNode<AudioStreamPlayer>("TitleMusic");
		music.Stream = GD.Load<AudioStream>("res://sound/music/Unrea_Superhero.ogg");
		music.Play();
	}
}
