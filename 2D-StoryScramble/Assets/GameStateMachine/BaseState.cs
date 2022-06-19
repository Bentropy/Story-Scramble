using UnityEngine;

public abstract class BaseState
{
    public abstract void EnterState(GameStateFSM context);

    public abstract void Update(GameStateFSM context);

    public abstract void ExitState();

    //having a reference to the context is not required by the states
    //above are just examples of how to do this when necessary
}
