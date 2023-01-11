/*
 * Nicolas Korsunski
 * 2022-11-21
 * button Event handler
 */
using UnityEngine;

public class ContinuousTurnEventHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("rightFingerInput"))
        {
            GlobalVariables.SnapTurn = false;
            GlobalVariables.ContinousTurn = true;
        }
    }

}
