using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreThreeIntroState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Genre Three Intro");
        throw new System.NotImplementedException("GenreThreeIntroState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("GenreThreeIntroState.Update");
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException("GenreThreeIntroState.ExitState");
    }
}