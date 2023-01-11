/*
 * Nicolas Korsunski
 * 2022-10-08
 * This script is for deleting the key on update and setting the global variable to true when collected.
 * This is an object and object event control script
 * To-Do: integrate other scripts into this one which set the global variable and are removed after
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class keyEvent : MonoBehaviour
{
    
    public GameObject key;
    private XRGrabInteractable interact;
    // Start is called before the first frame update
    void Start()
    {
        interact = this.GetComponent<XRGrabInteractionGrabFix>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (interact.isSelected.Equals(true) && this.tag.Equals("apartmentKey"))
        {
            GlobalVariables.ApartmentKey = true;
            Destroy(key);
        }
        else if (interact.isSelected.Equals(true) && this.tag.Equals("secretKey"))
        {
            GlobalVariables.SecretKey = true;
            Destroy(key);
        }
    }

}
