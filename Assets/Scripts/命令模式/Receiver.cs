using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour {

    public void MoveOperation(ActionType direction, float distance)
    {
        switch (direction)
        {
            case ActionType.up:
                MoveY(this.gameObject, distance);
                break;
            case ActionType.down:
                MoveY(this.gameObject, -distance);
                break;
            case ActionType.left:
                MoveX(this.gameObject, -distance);
                break;
            case ActionType.right:
                MoveX(this.gameObject, distance);
                break;
        }
    }

    private void MoveY(GameObject gameObjectToMove, float distance)
    {
        Vector3 newPos = gameObjectToMove.transform.position;
        newPos.y += distance;
        gameObjectToMove.transform.position = newPos;
    }

    private void MoveX(GameObject gameObjectToMove, float distance)
    {
        Vector3 newPos = gameObjectToMove.transform.position;
        newPos.x += distance;
        gameObjectToMove.transform.position = newPos;
    }
}
