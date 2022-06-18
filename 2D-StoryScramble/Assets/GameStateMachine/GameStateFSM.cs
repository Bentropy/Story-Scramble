using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateFSM : MonoBehaviour
{
    private BaseState currentState;

    public BaseState CurrentState
    {
        get { return currentState; }
    }

    //public readonly StructureUnselectedState UnselectedState = new StructureUnselectedState();
    //public readonly StructureSelectedState SelectedState = new StructureSelectedState();
    //public readonly StructureScaleState ScaleState = new StructureScaleState();
    //public readonly StructureRotateState RotateState = new StructureRotateState();
    public readonly WelcomeState GameWelcomeState = new WelcomeState();
    public readonly OrientationState GameOrientationState = new OrientationState();

    void Start()
    {
        TransitionToState(GameWelcomeState);
    }

    public void TransitionToState(BaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this);
    }

    void Update()
    {
        currentState.Update(this);
    }

    void OnMouseUp()
    {
        currentState.OnMouseUp(this);
    }

    public void OnMouseOver()
    {
        currentState.OnMouseOver(this);
    }

    void OnMouseDrag()
    {
        currentState.OnMouseDrag(this);
    }

    void OnMouseExit()
    {
        currentState.OnMouseExit(this);
    }

    void OnMouseDown()
    {
        currentState.OnMouseDown(this);
    }

    void OnMouseEnter()
    {
        currentState.OnMouseEnter(this);
    }
}