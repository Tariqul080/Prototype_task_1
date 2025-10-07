using UnityEngine;

public class MouseDragCamera : MonoBehaviour
{
    public float rotationSpeed = 3f;
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up * mouseX * rotationSpeed, Space.World);
        }
    }
}
