using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerEventController : MonoBehaviour
{
    public GameObject cDisplay;
    // Start is called before the first frame update
    void Start()
    {
        cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Welcome please press the down arrow key to scroll through terminal options.";
    }

    void Update()
    {
        if(GlobalVariables.OptionCycle == 0)
        {
            GlobalVariables.SpaceKeyPressed = false;
            cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Welcome please press the down arrow key to scroll through terminal options.";
        }
        else if(GlobalVariables.OptionCycle == 1)
        {
            GlobalVariables.SpaceKeyPressed = false;
            cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Janitor's lock box code: OPEN";
        }
        else if(GlobalVariables.OptionCycle == 2)
        {

            GlobalVariables.SpaceKeyPressed = false;
            cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Underground exit key stored in Captian King's desk";
        }
        else if(GlobalVariables.OptionCycle == 3 && GlobalVariables.SpaceKeyPressed)
        {
            GlobalVariables.IsKingDistracted = true;
            StartCoroutine(ReturnMessage());
            cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "King has been reminded";
        }
        else if(GlobalVariables.OptionCycle == 3 && GlobalVariables.SpaceKeyPressed == false)
        {
            cDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Remind Head Captian King of their meeting, in 15 minutes? \nPress Space\nto notify";
        }
    }

    IEnumerator ReturnMessage()
    {
        yield return new WaitForSeconds(1.5f);
        GlobalVariables.SpaceKeyPressed = false;
    }
}
