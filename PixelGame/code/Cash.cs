using Godot;
using System;

public partial class Cash : Node
{
	
	private int funds = 0; // Declares funds var
	private string labelt;
	public override void _Process(double delta)
	{
		var lb = GetNode<Label>("Status");	// Changes the status message depending on how rich you are
			if(funds<100)
				lb.Text = ("Status: Broke as shit");
			else if(funds<500)
				lb.Text = ("Status: Kinda rich");
			else if(funds<1000)
				lb.Text = ("Status: Mega rich");

	}
	// This looks like a mess which it probably is. But I dont care right now
	private void _on_texture_button_pressed()
	{
		funds += 1;
		var lb = GetNode<Label>("MoneyLabel");
		string labelt = funds.ToString();
		lb.Text = (labelt);
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		noise.Play();
	}
}



