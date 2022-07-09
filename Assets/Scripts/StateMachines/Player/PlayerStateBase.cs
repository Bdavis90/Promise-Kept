using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase : State
{
    protected PlayerStateMachine stateMachine;

    protected PlayerStateBase(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
