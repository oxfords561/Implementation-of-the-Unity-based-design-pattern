using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : PeopleState {

    private People _people;

    public RunState(People people)
    {
        _people = people;
    }

    public void Update()
    {

    }

    public void HandleInput()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            _people.GetPeopleController().SetBool("walk",false);
            _people.SetPeopleState(new StandState(_people));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _people.GetPeopleController().SetBool("walk", true);
            _people.SetPeopleState(new RunState(_people));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _people.GetPeopleController().SetTrigger("jump");
            _people.SetPeopleState(new JumpState(_people));
        }
    }
}
