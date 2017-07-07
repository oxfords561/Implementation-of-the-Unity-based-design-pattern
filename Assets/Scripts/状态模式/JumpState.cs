using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : PeopleState {

    private People _people;

    public JumpState(People people)
    {
        _people = people;
    }

    public void HandleInput()
    {
        AnimatorStateInfo stateinfo = _people.GetPeopleController().GetCurrentAnimatorStateInfo(0);
        if (stateinfo.IsName("Lomtion"))
        {
            _people.SetPeopleState(new RunState(_people));
        }
    }

    public void Update()
    {

    }
}
