using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationState : BaseState
{
    private static GameObject orientationScreen;

    public override void EnterState(GameStateFSM context)
    {
        orientationScreen = Resources.Load("OrientationStateScreen") as GameObject;
        GameObject.Instantiate(orientationScreen, context.can.transform, false);
        //throw new System.NotImplementedException("OrientationState.EnterState");
    }

    public override void Update(GameStateFSM context)
    {
        //throw new System.NotImplementedException("OrientationState.Update");
    }

    public override void ExitState()
    {
        Object.Destroy(orientationScreen);
        //throw new System.NotImplementedException("OrientationState.ExitState");
    }
}