using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
/*
 * This is a class object which will be used as a controller for the hand interactions and physical controller values & overall controls
 */
[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    ActionBasedController controller;
    //allows access and control over the hand animation object through the controller object (associated with physical controller)
    public Hand animatedHand;
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets the target values n the object class controlled by this controller object class
        animatedHand.SetGrip(controller.selectAction.action.ReadValue<float>());
        animatedHand.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
