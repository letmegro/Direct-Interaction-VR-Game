/*
 * Nicolas Korsunski
 * 2022-10-12
 * camera disabling event script
 */
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HallCameraEvent : MonoBehaviour
{
    public GameObject detectionArea;
    private XRGrabInteractable interact;
    // Start is called before the first frame update
    void Start()
    {
        interact = this.GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interact.isSelected)
        {
            Destroy(detectionArea);
        }
    }
}
