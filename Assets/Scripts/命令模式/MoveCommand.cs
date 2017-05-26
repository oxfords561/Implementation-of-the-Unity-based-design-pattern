using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command {

    public ActionType _type;
    private Receiver _receiver;
    private float moveDistance = 50f;

    public MoveCommand(ActionType type,Receiver receiver) 
    {
        this._type = type;
        this._receiver = receiver;
    }

    public void UnExecute()
    {
        _receiver.MoveOperation(_type, -moveDistance);
    }

    public void Execute()
    {
        _receiver.MoveOperation(_type, moveDistance);
    }
    
}
