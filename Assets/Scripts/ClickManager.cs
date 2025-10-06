using UnityEngine;

public class ClickManager : MonoBehaviour
{
    private GameObject selectedObject = null;
    private Vector3 selectedObjPos = Vector3.zero;
    private float objectZDistance;

    public void ClearSelection()
    {
        selectedObject = null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.CompareTag("Clickable"))
                {
                    selectedObject = hit.collider.gameObject;
                    selectedObjPos = selectedObject.transform.position;
                    objectZDistance = Camera.main.WorldToScreenPoint(selectedObject.transform.position).z;
                    Debug.Log("Clicked on: " + selectedObject.name);
                }
            }
        }

        // While holding mouse, move object
        if (Input.GetMouseButton(0) && selectedObject != null)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = objectZDistance;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            selectedObject.transform.position = worldPos;
        }

        // Release mouse button to drop
        if (Input.GetMouseButtonUp(0) && selectedObject != null)
        {
            selectedObject.transform.position = selectedObjPos;
            selectedObject = null;
        }
    }
}
