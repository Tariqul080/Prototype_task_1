using UnityEngine;

public class TargetPoint : MonoBehaviour
{
    [SerializeField] private Transform thermometerPos = null;

    private bool isThermometerDone = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Clickable"))
        {
            GameObject ob = other.gameObject;
            MoveableItem item = ob.GetComponent<MoveableItem>();

            if (item != null)
            {
                if (item.isThermometer && !isThermometerDone)
                {
                    isThermometerDone = true;
                    item.StopMoving();
                    ob.transform.position = thermometerPos.position;
                }
            }
        }
    }
}
