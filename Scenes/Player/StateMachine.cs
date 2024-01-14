using Godot;
using System;

public partial class StateMachine : Node
{

[Export]
public State startingState;
[Export]
public State currentState;
public void Init(Player parent)
    {
        foreach (Node child in GetChildren())
        {
            if (child is State state)
            {
                state.SetParent(parent);
            }
        }
    }



}


