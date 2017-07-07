using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackState : PeopleState {

    private People _people;

    public BackState(People people)
    {
        _people = people;
    }

    public void HandleInput()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            _people.GetPeopleController().SetBool("back",false);
            _people.SetPeopleState(new StandState(_people));
        }
    }

    public void Update()
    {

    }
}
