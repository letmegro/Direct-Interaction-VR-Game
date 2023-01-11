using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowEvent : MonoBehaviour
{
    public Material hover;
    public Material noHover;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("leftFingerInput") || other.gameObject.tag.Equals("rightFingerInput"))
        {
            this.GetComponent<Renderer>().material.color = hover.color;
            if (GlobalVariables.OptionCycle > 0)
            {
                GlobalVariables.OptionCycle = GlobalVariables.OptionCycle - 1;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = noHover.color;

    }
}
