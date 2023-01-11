using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigationEventController : MonoBehaviour
{
    public Animator animate;
    private bool animationHappened;

    private void LateUpdate()
    {
        if (GlobalVariables.IsDistracted == true && animationHappened == false)
        {
            animate.Rebind();
            animate.SetBool("isThereSmoke", true);
            animationHappened = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("smokeBomb"))
        {
            GlobalVariables.IsDistracted = true;
        }
    }

}
