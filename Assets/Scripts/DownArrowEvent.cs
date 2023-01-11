/*
 * Nicolas Korsunski
 * 2022-12-01
 * Down key virtual key event handler
 */
using UnityEngine;

public class DownArrowEvent : MonoBehaviour
{
    public Material hover;
    public Material noHover;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("leftFingerInput") || other.gameObject.tag.Equals("rightFingerInput"))
        {
            this.GetComponent<Renderer>().material.color = hover.color;
            if (GlobalVariables.OptionCycle < 3)
            {
                GlobalVariables.OptionCycle = GlobalVariables.OptionCycle + 1;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = noHover.color;

    }

}
