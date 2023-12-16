using Godot;
using System;

public partial class Cash : Node
{
	
	private int funds = 0; // Declares funds var
	private int income = 0; // Income per second
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
			else if(funds<10000)
				lb.Text = ("Status: Evil");

		var yeslabel = GetNode<Label>("MoneyLabel"); // Assigns the value of funds to the label 
		string labelt = funds.ToString();
		yeslabel.Text = (labelt);

		var incomelabel = GetNode<Label>("IncomeLabel"); // Assigns the value of funds to the label 
		string labelm = income.ToString();
		incomelabel.Text = (labelm + " Per Second");

	}
	// This looks like a mess which it probably is. But I dont care right now
	private void _on_texture_button_pressed()
	{
		funds += 1;
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		noise.Play();
	}
	private void _on_button_pressed()
	{
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		var badnoise = GetNode<AudioStreamPlayer>("BadClick");
		badnoise.Stream = GD.Load<AudioStream>("res://sound/sfx/bad.wav");
		if(funds>99)
		{
			income += 1;
			funds -= 100;
			noise.Play();
		}
		else
		{
			badnoise.Play();
		}
	}

	private void _on_button_2_pressed()
	{
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		var badnoise = GetNode<AudioStreamPlayer>("BadClick");
		badnoise.Stream = GD.Load<AudioStream>("res://sound/sfx/bad.wav");
		if(funds>199)
		{
			income += 5;
			funds -= 200;
			noise.Play();
		}
		else
		{
			badnoise.Play();
		}
	}

	private void _on_button_3_pressed()
	{
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		var badnoise = GetNode<AudioStreamPlayer>("BadClick");
		badnoise.Stream = GD.Load<AudioStream>("res://sound/sfx/bad.wav");
		if(funds>499)
		{
			income += 10;
			funds -= 500;
			noise.Play();
		}
		else
		{
			badnoise.Play();
		}
	}


	private void _on_button_4_pressed()
	{
		var noise = GetNode<AudioStreamPlayer>("Click");
		noise.Stream = GD.Load<AudioStream>("res://sound/sfx/tap.wav");
		var badnoise = GetNode<AudioStreamPlayer>("BadClick");
		badnoise.Stream = GD.Load<AudioStream>("res://sound/sfx/bad.wav");
		if(funds>999)
		{
			income += 50;
			funds -= 1000;
			noise.Play();
		}
		else
		{
			badnoise.Play();
		}
	}
	private void _on_income_timer_timeout() // Paycheck :D
	{
		funds += income;
	}	
}








