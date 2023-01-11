/*
 * Nicolas Korsunski
 * 2022-12-02
 * space bar event handler
 */
using UnityEngine;

public class SpaceEnterEvent : MonoBehaviour
{
    public Material hover;
    public Material noHover;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("leftFingerInput") || other.gameObject.tag.Equals("rightFingerInput"))
        {
            this.GetComponent<Renderer>().material.color = hover.color;
            GlobalVariables.SpaceKeyPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = noHover.color;

    }

}
