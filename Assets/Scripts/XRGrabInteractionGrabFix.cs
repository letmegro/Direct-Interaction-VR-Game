using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractionGrabFix : XRGrabInteractable
{
    public Transform leftHandAttach;
    public Transform rightHandAttach;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LHand"))
        {
            attachTransform = leftHandAttach;
        }
        else if (args.interactorObject.transform.CompareTag("RHand"))
        {
            attachTransform = rightHandAttach;
        }

        base.OnSelectEntered(args);
    }

}
