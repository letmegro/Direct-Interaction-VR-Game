using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    //control variables
    Animator animator;
    private float gripTarget;
    private float currentGrip;
    private float triggerTarget;
    private float currentTrigger;
    private float resetHand;
    //public rate control variable
    public float rot;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // modification idea: update only when there is a change in controller input to avoid constant animation call and wasted resources
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        //resets hand to hand position
        if (gripTarget == 0 && triggerTarget == 0 && gripTarget == currentGrip && triggerTarget == currentTrigger)
        {
            resetHand = Mathf.MoveTowards(currentGrip, 0, Time.deltaTime * rot);
            animator.SetFloat("Grip", resetHand);
            resetHand = Mathf.MoveTowards(currentTrigger, 0, Time.deltaTime * rot);
            animator.SetFloat("Trigger", resetHand);
        }
        //controls the grip animation
        if (currentGrip != gripTarget && currentTrigger == triggerTarget)
        {
            currentGrip = Mathf.MoveTowards(currentGrip, gripTarget, Time.deltaTime * rot);
            animator.SetFloat("Grip", currentGrip);
            currentTrigger = Mathf.MoveTowards(currentTrigger, triggerTarget, Time.deltaTime * rot);
            animator.SetFloat("Trigger", currentTrigger);
        }
        //controls the point animation
        else if(currentTrigger != triggerTarget && currentGrip == gripTarget)
        {
            currentGrip = Mathf.MoveTowards(currentGrip, gripTarget, Time.deltaTime * rot);
            animator.SetFloat("Grip", currentGrip);
            currentTrigger = Mathf.MoveTowards(currentTrigger, triggerTarget, Time.deltaTime * rot);
            animator.SetFloat("Trigger", currentTrigger);
        }
        
    }

}
