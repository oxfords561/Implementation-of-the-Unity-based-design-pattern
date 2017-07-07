using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People {

    PeopleState _state;

    private Animator _anim;

    public People()
    {
        //设置默认的人物状态
        _state = new StandState(this);
    }

    public void SetPeopleState(PeopleState newState)
    {
        _state = newState;
    }

    public Animator GetPeopleController()
    {
        if (_anim != null)
            return _anim;
        return null;
    }

    public void HandleInput()
    {

    }

    public void SetAnimatorController(Animator anim)
    {
        _anim = anim;
    }

    public void Update()
    {
        _state.HandleInput();
    }
}
