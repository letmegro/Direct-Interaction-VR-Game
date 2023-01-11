using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapTurnEventHandler : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("rightFingerInput"))
        {
            GlobalVariables.SnapTurn = true;
            GlobalVariables.ContinousTurn = false;
        }
    }

}
