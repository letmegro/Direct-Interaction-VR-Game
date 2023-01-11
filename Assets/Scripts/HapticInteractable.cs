/*
 * this script started off as an experiment based on methods which the player could get haptic feedback
 * 2022-11-03
 */
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[System.Serializable]
public class Haptic
{
    [Range(0, 1)]
    public float intensity;
    public float duration;

    public void TriggerHaptic(BaseInteractionEventArgs args)
    {
        if (args.interactorObject is XRBaseControllerInteractor interactor)
        {
            TriggerHaptic(interactor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if (intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}

public class HapticInteractable : MonoBehaviour
{
    public Haptic hapticOnActivated;
    public Haptic hapticHoverEntered;
    public Haptic hapticHoverExited;
    public Haptic hapticSelectEntered;
    public Haptic hapticSelectExited;
    private XRBaseInteractable gunTriggerPressed;
    void Start()
    {
        gunTriggerPressed = GetComponent<XRBaseInteractable>();
        gunTriggerPressed.activated.AddListener(hapticOnActivated.TriggerHaptic);
        gunTriggerPressed.hoverEntered.AddListener(hapticHoverEntered.TriggerHaptic);
        gunTriggerPressed.hoverExited.AddListener(hapticHoverExited.TriggerHaptic);
        gunTriggerPressed.selectEntered.AddListener(hapticSelectEntered.TriggerHaptic);
        gunTriggerPressed.selectExited.AddListener(hapticSelectExited.TriggerHaptic);
    }

    
}
