using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator thermometerAnim = null;

    public void StartTempAnim()
    {
        thermometerAnim.SetTrigger("start");
    }

    public void StopTempAnim()
    {
        thermometerAnim.SetTrigger("stop");
    }
}
