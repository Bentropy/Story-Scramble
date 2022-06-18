using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(GameStateFSM context);

    public abstract void Update(GameStateFSM context);

    public abstract void OnCollisionEnter(GameStateFSM context);

    public abstract void OnMouseUp(GameStateFSM context);

    public abstract void OnMouseDown(GameStateFSM context);

    public abstract void OnMouseOver(GameStateFSM context);

    public abstract void OnMouseDrag(GameStateFSM context);

    public abstract void OnMouseExit(GameStateFSM context);

    public abstract void OnMouseEnter(GameStateFSM context);

    //having a reference to the context is not required by the states
    //above are just examples of how to do this when necessary
}
