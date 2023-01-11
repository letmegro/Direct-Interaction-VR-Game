using System.Collections;
using UnityEngine;

public class FrontDeskPlacementController : MonoBehaviour
{
    public GameObject invisibleWall;
    
    private void OnTriggerEnter(Collider other)
    {
        if (this.tag.Equals("frontdesk") && (other.tag.Equals("RHand") || other.tag.Equals("LHand")) && GlobalVariables.IsDistracted == false)
        {
            GlobalVariables.IsPaperReachedFor = true;
            int newLayer = LayerMask.NameToLayer("invisible-wall");
            invisibleWall.layer = newLayer;
            StartCoroutine(ReadyGun());
        }
    }

    IEnumerator ReadyGun()
    {
        yield return new WaitForSeconds(1);
    }
}

