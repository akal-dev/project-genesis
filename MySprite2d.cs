using Godot;
using System;

public partial class MySprite2d : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;
	private bool _isMoving = false;
	
	public MySprite2d()
	{
		GD.Print("Hello World!");
	}
	
	public override void _Process(double delta)
	{
		var direction = 0;
		if (Input.IsActionPressed("ui_left") || _isMoving)
		{
			direction = -1;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			direction = 1;
		}
		
		Rotation += direction * _angularSpeed * (float)delta;
		
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("ui_up") || _isMoving)
			velocity = Vector2.Up.Rotated(Rotation) * _speed;
		Position += velocity * (float)delta;
	}
	
	private void OnButtonPressed()
	{
		_isMoving = !_isMoving;
	}
}
