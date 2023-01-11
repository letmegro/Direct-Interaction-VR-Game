/*
 * Nicolas Korsunski
 * 2022-11-18
 * Script is used to control an event in the reception area (script should be rewritten in a way so it can be merged with another event controller
 * of a similar area).
 */
using UnityEngine;

public class NoSmokeEventController : MonoBehaviour
{
    public Animator animate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("smokeBomb"))
        {
            GlobalVariables.IsPaperReachedFor = true;
            Debug.Log("here");
            animate.SetBool("canAim", true);
        }
    }

}
