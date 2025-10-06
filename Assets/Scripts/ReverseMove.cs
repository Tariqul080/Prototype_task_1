using UnityEngine;
public class ReverseMove : MonoBehaviour
{
    public bool isThermometerDone;
    public bool isSeedDone;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello debug im revers");
        GameObject obj = other.gameObject;
        MoveableItem moveItem = obj.GetComponent<MoveableItem>();
        if (obj != null && obj.CompareTag("Clickable") && moveItem.move_to_wonPos)
        {
            obj.transform.position = moveItem.parentTrans.position;
            moveItem.move_to_wonPos = false;
            if (moveItem.isThermometer)
            {
                isThermometerDone = true;
            }
            else
            {
                isSeedDone = true;
            }
            moveItem.StopMoving();
        }
    }
}
