using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class LockBoxPuzzle : MonoBehaviour
{
    Animator animateBox;
    public AudioSource successSound;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b0;
    public GameObject textPadDisplay;
    public XRBaseController rightController, leftController;
    private string passcode;

    void Start()
    {
        successSound.loop = false;
        successSound.playOnAwake = false;
        animateBox = GetComponent<Animator>();
        passcode = "6736";
        textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "__ __ __ __";
    }

    void Update()
    {
        if(GlobalVariables.InputPuzzle.Length.Equals(0))
        {
            textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "__ __ __ __";
        }
        else if(GlobalVariables.InputPuzzle.Length.Equals(4))
        {
            textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = GlobalVariables.InputPuzzle;
            if (passcode.Equals(GlobalVariables.InputPuzzle))
            {
                successSound.Play();
                StartCoroutine(CorrectPasscode());
                animateBox.SetBool("unlocked", true);
            }
            else
            {
                //play incorrect code sound
                StartCoroutine(IncorrectPasscode());
            }
        }
        else
        {
            textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = GlobalVariables.InputPuzzle;
        }

    }
    IEnumerator CorrectPasscode()
    {
        textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(0, 1, 0, 1);
        yield return new WaitForSeconds(1);
        textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
        GlobalVariables.InputPuzzle = "";
    }
    IEnumerator IncorrectPasscode()
    {
        textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(1, 0, 0, 1);
        rightController.SendHapticImpulse(0.3f, 0.2f);
        leftController.SendHapticImpulse(0.3f, 0.2f);
        yield return new WaitForSeconds(1);
        textPadDisplay.GetComponent<TMPro.TextMeshProUGUI>().color = new Color(1, 1, 1, 1);
        GlobalVariables.InputPuzzle = "";
    }
}
