using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class buttonHover : MonoBehaviour
{
    public Material hover;
    public Material noHover;
    public AudioSource buttonSound;
    public XRBaseController rightController, leftController;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag.Equals("leftFingerInput") || other.gameObject.tag.Equals("rightFingerInput"))
        {
            buttonSound.Play();
            if (other.tag.Equals("leftFingerInput"))
            {
                leftController.SendHapticImpulse(0.1f, 0.1f);
            }
            else
            {
                rightController.SendHapticImpulse(0.1f, 0.1f);
            }
            this.GetComponent<Renderer>().material.color = hover.color;
            if (GlobalVariables.InputPuzzle.Length < 4)
            {
                string buttonName = this.gameObject.name;
                switch (buttonName)
                {
                    case "one":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '1';
                        break;
                    case "two":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '2';
                        break;
                    case "three":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '3';
                        break;
                    case "four":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '4';
                        break;
                    case "five":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '5';
                        break;
                    case "six":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '6';
                        break;
                    case "seven":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '7';
                        break;
                    case "eight":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '8';
                        break;
                    case "nine":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '9';
                        break;
                    case "zero":
                        GlobalVariables.InputPuzzle = GlobalVariables.InputPuzzle + '0';
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Renderer>().material.color = noHover.color;
        
    }

}
