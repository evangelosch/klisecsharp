using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private  Node stateMachine;



public override void _Ready()
{
    stateMachine = GetNode<Node>("StateMachine");
	

}




}