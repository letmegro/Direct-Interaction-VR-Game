/*
 * Nicolas Korsunski
 * 2022-12-05
 * walk through door event handler
 */
using UnityEngine;

public class WalkThroughEventTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            GlobalVariables.HeadOfficeEntered = true;
        }
    }
}
