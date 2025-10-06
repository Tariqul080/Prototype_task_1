using System;
using UnityEngine;

public class MoveableItem : MonoBehaviour
{
    [SerializeField] private ClickManager clickManager;
    public Transform parentTrans;
    public bool move_to_wonPos;
    public bool isThermometer = true;
    public int index;
    public void StopMoving()
    {
        clickManager.ClearSelection();
    }
}
