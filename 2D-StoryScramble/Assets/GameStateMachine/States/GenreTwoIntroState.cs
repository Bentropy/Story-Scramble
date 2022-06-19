using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreTwoIntroState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Genre Two Intro");
        throw new System.NotImplementedException("GenreTwoIntroState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("GenreTwoIntroState.Update");
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException("GenreTwoIntroState.ExitState");
    }
}