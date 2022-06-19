using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherWelcomeState : BaseState
{
    public override void EnterState(GameStateFSM context)
    {
        Debug.Log("Teacher Welcome");
        throw new System.NotImplementedException("TeacherWelcomeState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("TeacherWelcomeState.Update");
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException("TeacherWelcomeState.ExitState");
    }
}