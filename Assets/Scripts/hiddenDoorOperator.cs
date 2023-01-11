/*
 * Nicolas Korsunski
 * 2022-11-18
 * This script is an event controller for opening a hidden door when the right book is grabbed
 */
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class hiddenDoorOperator : MonoBehaviour
{

    public  GameObject hiddenDoor;
    public AudioSource openingSound;
    private XRGrabInteractable interact;
    private bool open = false;

    void Start()
    {
        interact = this.GetComponent<XRGrabInteractable>();
        openingSound.playOnAwake = false;
        openingSound.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (interact.isSelected == true && open == false)
        {
            openingSound.Play();
            hiddenDoor.SetActive(false);
            open = true;
        }
    }

}
