using Godot;
using System;

public partial class Player : Node2D
{
	private float _speed = 400;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 direction = new Vector2(
			Input.GetAxis("ui_left", "ui_right"),
			Input.GetAxis("ui_up", "ui_down")
		);

		Vector2 velocity = _speed * (float)delta * direction;
		Position += velocity;
	}
}
