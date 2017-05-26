using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
    up,
    down,
    left,
    right,
    undo,
    redo
}

public class InputHandler : MonoBehaviour {

    [SerializeField]
    private Receiver receiver;
    private List<MoveCommand> commands = new List<MoveCommand>();
    private int currentCommandNum = 0;

    /// <summary>
    /// 点击向上按钮
    /// </summary>
    public void OnUpClickEvent(){Move(ActionType.up,receiver);}

    /// <summary>
    /// 点击向下按钮
    /// </summary>
    public void OnDownClickEvent(){Move(ActionType.down,receiver);}

    /// <summary>
    /// 点击向左按钮
    /// </summary>
    public void OnLeftClickEvent(){Move(ActionType.left,receiver);}

    /// <summary>
    /// 点击向右按钮
    /// </summary>
    public void OnRightClickEvent(){Move(ActionType.right,receiver);}

    /// <summary>
    /// 点击重做按钮
    /// </summary>
    public void OnRedoClickEvent()
    {
         if (currentCommandNum <= commands.Count)
        {
            MoveCommand moveCommand = commands[currentCommandNum - 1];
            commands.Add(moveCommand);
            currentCommandNum++;
            moveCommand.Execute();
        }
    }

    /// <summary>
    /// 点击撤销按钮
    /// </summary>
    public void OnUndoClickEvent()
    {
        if (currentCommandNum > 0)
        {
            currentCommandNum--;
            MoveCommand moveCommand = commands[currentCommandNum];
            moveCommand.UnExecute();
            print("<< " + moveCommand._type.ToString());
        }
    }

    void Move(ActionType type,Receiver receiver)
    {
        MoveCommand moveCommand = new MoveCommand(type,receiver);
        moveCommand.Execute();
        commands.Add(moveCommand);
        currentCommandNum ++;
        print(">> " + moveCommand._type.ToString());
    }
}
