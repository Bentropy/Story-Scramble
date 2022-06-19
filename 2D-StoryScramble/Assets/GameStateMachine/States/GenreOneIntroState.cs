using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreOneIntroState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Genre One Intro");
        throw new System.NotImplementedException("GenreOneIntroState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("GenreOneIntroState.Update");
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException("GenreOneIntroState.ExitState");
    }
}