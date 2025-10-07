using System;
using UnityEngine;

public class MoveableItem : MonoBehaviour
{
    public ClickManager clickManager;
    public bool isTargetBattalA = true;

    public Transform indicator_own_pos;
    public Transform indicator_final_pos;
    public Transform parentTrans;
    public Transform moveTrans;
    public bool isParentPos = true;
    public bool isThermometer = true;
    public int currentPos;
    public int finalPos;
    public int move_Counter = 0;

    public void MovePos()
    {
        if (move_Counter == 0)
        {
            transform.position = moveTrans.position;
            move_Counter = 1;
            isParentPos = false;
        }
        else
        {
            transform.position = parentTrans.position;
            move_Counter = 0;
            isParentPos = true;
        }
    }

    public void StopMoving()
    {
        clickManager.ClearSelection();
    }

    public void Restart()
    {
        isParentPos = true;
        move_Counter = 0;
        transform.position = parentTrans.position;
    }
}
