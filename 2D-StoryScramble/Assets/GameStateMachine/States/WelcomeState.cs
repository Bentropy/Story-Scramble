using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Welcome");
        throw new System.NotImplementedException("WelcomeState.EnterState");
    }

    public override void OnCollisionEnter(GameStateFSM context)
    {
        throw new System.NotImplementedException("WelcomeState.OnCollisionEnter");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("WelcomeState.Update");
    }

    public override void OnMouseUp(GameStateFSM context)
    {
        context.TransitionToState(context.GameOrientationState);
    }

    public override void OnMouseDown(GameStateFSM context)
    {
        throw new System.NotImplementedException("StructureRotateState.OnMouseDown");
    }

    public override void OnMouseOver(GameStateFSM context)
    {
        throw new System.NotImplementedException("StructureRotateState.OnMouseOver");
    }

    public override void OnMouseDrag(GameStateFSM context)
    {
        throw new System.NotImplementedException("StructureRotateState.OnMouseDrag");
    }

    public override void OnMouseExit(GameStateFSM context)
    {
        throw new System.NotImplementedException("StructureRotateState.OnMouseExit");
    }

    public override void OnMouseEnter(GameStateFSM context)
    {
        throw new System.NotImplementedException("StructureRotateState.OnMouseEnter");
    }
}