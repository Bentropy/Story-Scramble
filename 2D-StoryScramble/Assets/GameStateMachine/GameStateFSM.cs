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

    public Canvas can;

    public readonly WelcomeState GameWelcomeState = new WelcomeState();
    public readonly TeacherWelcomeState GameTeacherWelcomeState = new TeacherWelcomeState();
    public readonly TeacherIdeasState GameTeacherIdeasState = new TeacherIdeasState();
    public readonly OrientationState GameOrientationState = new OrientationState();
    public readonly GenreSelectionState GameGenreSelectionState = new GenreSelectionState();
    public readonly GenreOneIntroState GameGenreOneIntroState = new GenreOneIntroState();
    public readonly GenreTwoIntroState GameGenreTwoIntroState = new GenreTwoIntroState();
    public readonly GenreThreeIntroState GameGenreThreeIntroState = new GenreThreeIntroState();
    public readonly GenreOnePlotSelectionState GameGenreOnePlotSelectionState = new GenreOnePlotSelectionState();
    public readonly GenreTwoPlotSelectionState GameGenreTwoPlotSelectionState = new GenreTwoPlotSelectionState();
    public readonly GenreThreePlotSelectionState GameGenreThreePlotSelectionState = new GenreThreePlotSelectionState();

    void Start()
    {
        TransitionToState(GameWelcomeState);
    }

    public void TransitionToState(BaseState state)
    {
        if(currentState != null)
        {
            currentState.ExitState();
        }
        currentState = state;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.Update(this);
    }
}