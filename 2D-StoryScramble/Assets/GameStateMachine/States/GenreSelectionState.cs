using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreSelectionState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Genre Selection");
        throw new System.NotImplementedException("GenreSelectionState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("GenreSelectionState.Update");
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException("GenreSelectionState.ExitState");
    }
}