using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandState : PeopleState
{

    private People _people;

    public StandState(People people)
    {
        _people = people;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _people.GetPeopleController().SetBool("walk", true);
            _people.SetPeopleState(new RunState(_people));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _people.GetPeopleController().SetBool("back",true);
            _people.SetPeopleState(new BackState(_people));
        }
    }

    public void Update()
    {
        
    }
}
