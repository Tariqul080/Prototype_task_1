using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private Transform thermometerPos = null;
    [SerializeField] private Transform seedPos = null;

    public bool isThermometerDone = false;
    public bool isSeedDone = false;

    private void OnTriggerEnter(Collider other)
    {
        GameObject game_object = other.gameObject;
        MoveableItem item = other.GetComponent<MoveableItem>();

        if (game_object.CompareTag("Clickable") && item.isThermometer)
        {
            if (item != null)
            {
                if (item.isThermometer && !isThermometerDone)
                {
                    isThermometerDone = true;
                    item.move_to_wonPos = true;
                    item.StopMoving();
                    game_object.transform.position = thermometerPos.position;

                }
            }
        }
        else
        {
            if (item != null)
            {
                if (!item.isThermometer && !isSeedDone)
                {
                    isSeedDone = true;
                    item.move_to_wonPos = true;
                    item.StopMoving();
                    game_object.transform.position = seedPos.position;
                }
            }
        }
    }
}
