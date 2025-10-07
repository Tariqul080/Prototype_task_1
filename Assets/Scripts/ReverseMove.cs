using UnityEngine;
public class ReverseMove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        MoveableItem moveItem = obj.GetComponent<MoveableItem>();

        if (obj != null && obj.CompareTag("Clickable") && moveItem.move_Counter != 0)
        {
            moveItem.StopMoving();
            moveItem.MovePos();
        }
    }
}
