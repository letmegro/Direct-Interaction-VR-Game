using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SmokeActivate : MonoBehaviour
{
    public XRBaseController rightController, leftController;
    public ParticleSystem smoke;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("RHand") || other.tag.Equals("LHand"))
        {
            if (other.tag.Equals("RHand"))
            {
                rightController.SendHapticImpulse(0.1f, 0.1f);
            }
            else
            {
                leftController.SendHapticImpulse(0.1f, 0.1f);
            }
            StartCoroutine(LaunchSmoke());
        }
    }

    IEnumerator LaunchSmoke()
    {
        yield return new WaitForSeconds(5);
        smoke.Play();
    }

}
