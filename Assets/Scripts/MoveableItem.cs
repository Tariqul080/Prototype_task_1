using UnityEngine;

public class MoveableItem : MonoBehaviour
{
    [SerializeField] private ClickManager clickManager;
    public bool isThermometer = true;


    public void StopMoving()
    {
        clickManager.ClearSelection();
    }
}
