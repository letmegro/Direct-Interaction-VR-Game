/**
 * Nicolas Korsunski
 * 2022-11-03
 * This is a user cc display text control script and is incharge of displaying text for different events
 * The control variables are to ensure no repeat of the same text unless it is necessary
 * currently all the subtitles/text notifications are in English (international)
 */
using System.Collections;
using UnityEngine;

public class TextDisplayController : MonoBehaviour
{
    public GameObject text;
    private bool isKeyDisplayed;
    private bool isSecretDocDisplayed;
    private bool isInspected;

    void Start()
    {
        isKeyDisplayed = false;
        isSecretDocDisplayed = false;
        isInspected = false;
        text.SetActive(false);
        
    }

    //Note: can be turned into a switch statement or refactored to be cleaner and more efficient 
    void Update()
    {
        if(GlobalVariables.SecretKey && isKeyDisplayed == false)
        {
            isKeyDisplayed = true;
            text.GetComponent<TMPro.TextMeshProUGUI>().text = "Underground exit unlocked";
            display();
        }
        else if (GlobalVariables.SecretDoc && isSecretDocDisplayed == false)
        {
            isSecretDocDisplayed = true;
            text.GetComponent<TMPro.TextMeshProUGUI>().text = "Secret files on Agent Chris have been";
            display();
        }
        else if(GlobalVariables.CheckPointATriggered && isInspected == false)
        {
            isInspected = true;
            text.GetComponent<TMPro.TextMeshProUGUI>().text = "Wait right there! I need to inspect you.";
            StartCoroutine(DisplayUniqueCheckPointMsg());
            
        }
        else if (GlobalVariables.MedicineGiven)
        {
            text.GetComponent<TMPro.TextMeshProUGUI>().text = "Thank you for saving me, I just need a moment to rest";
            display();
            GlobalVariables.MedicineGiven = false;
        }
    }

    private void display()
    {
        text.SetActive(true);
        StartCoroutine("DisplayText");
    }

    IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }

    IEnumerator DisplayUniqueCheckPointMsg()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(4);
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Everything seems to checkout, you may proceed.";
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }

}
