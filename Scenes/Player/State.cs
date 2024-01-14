using Godot;
using System;

public abstract partial class State : Node
{
	
    public float moveSpeed = 400;
    public Player parent;
    public abstract void Enter();
    public abstract void Exit();
    public abstract State ProcessInput(InputEvent inputEvent);
    public abstract State ProcessFrame(float delta);
    public abstract State ProcessPhysics(float delta);

	public void SetParent(Player player) 
    {
        parent = player;
    }
}