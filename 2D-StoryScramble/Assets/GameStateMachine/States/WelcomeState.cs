using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeState : BaseState
{
    private static GameObject welcomeScreen;

    public override void EnterState(GameStateFSM context)
    {
        welcomeScreen = Resources.Load("WelcomeStateScreen") as GameObject;
        GameObject.Instantiate(welcomeScreen, context.can.transform, false);
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("WelcomeState.Update");
    }

    public override void ExitState()
    {
        Object.Destroy(welcomeScreen);
        //throw new System.NotImplementedException("WelcomeState.ExitState");
    }
}