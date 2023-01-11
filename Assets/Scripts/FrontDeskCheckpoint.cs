using System.Collections;
using UnityEngine;
public class FrontDeskCheckpoint : MonoBehaviour
{
    public Animator animateBox;
    public GameObject invisibleWall;
    private bool inspected;

    void Start()
    {
        inspected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag.Equals("Player") && inspected == false && GlobalVariables.IsPaperReachedFor == false)
        {
            GlobalVariables.CheckPointATriggered = true;
            StartCoroutine(InspectionAnimation());
            inspected = true;
            StartCoroutine(UnlockEntrance());
        }
        
    }

    IEnumerator InspectionAnimation()
    {
        animateBox.SetBool("checkPointA", true);
        yield return new WaitForSeconds(1);
        animateBox.SetBool("checkPointA", false);
    }

    IEnumerator UnlockEntrance()
    {
        yield return new WaitForSeconds(5);
        int newLayer = LayerMask.NameToLayer("invisible-wall");
        invisibleWall.layer = newLayer;
    }

}


