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
    private bool isUndo = false;


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
         if (currentCommandNum <= commands.Count && currentCommandNum > 0)
        {
            MoveCommand moveCommand = commands[currentCommandNum - 1];
            if (isUndo)
            {
                currentCommandNum--;
                moveCommand.UnExecute();
            }
            else
            {
                commands.Add(moveCommand);
                currentCommandNum++;
                moveCommand.Execute();
            }
            
        }
    }

    /// <summary>
    /// 点击撤销按钮
    /// </summary>
    public void OnUndoClickEvent()
    {
        if (currentCommandNum > 0)
        {
            isUndo = true;
            print("num "+currentCommandNum);
            MoveCommand moveCommand = commands[currentCommandNum - 1];
            moveCommand.UnExecute();
            for (int i = 0; i < commands.Count; i++)
            {
                print(commands[i]._type.ToString());
            }

            //commands.Remove(moveCommand);
            currentCommandNum--;
            print("<< " + moveCommand._type.ToString());
        }
    }

    void Move(ActionType type,Receiver receiver)
    {
        if (isUndo)
        {
            commands.RemoveRange(currentCommandNum,commands.Count - currentCommandNum);
        }
        isUndo = false;
        MoveCommand moveCommand = new MoveCommand(type,receiver);
        moveCommand.Execute();
        commands.Add(moveCommand);
        currentCommandNum ++;
        print(">> " + moveCommand._type.ToString());
    }
}
