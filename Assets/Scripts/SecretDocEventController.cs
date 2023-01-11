/*
 * Nicolas Korsunski
 * 2022-10-10
 * Secret document set and delete event script
 */
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SecretDocEventController : MonoBehaviour
{
    public GameObject secretDocument;
    private XRGrabInteractable interact;

    void Start()
    {
        interact = this.GetComponent<XRGrabInteractionGrabFix>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interact.isSelected)
        {
            GlobalVariables.SecretDoc = true;
            Destroy(secretDocument);
        }
    }

}
