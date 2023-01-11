
using UnityEngine;

public class ExitEvent : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("rightFingerInput"))
        {
            GlobalVariables.Exit = true;
        }
    }

}
