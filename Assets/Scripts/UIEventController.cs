/*
 * Nicolas Korsunski
 * 2022-11-21
 * This script is a controller for the different events which are made through the player UI interaction event handlers
 */
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class UIEventController : MonoBehaviour
{
    public Material on;
    public Material off;
    public GameObject menu;
    public GameObject cTurnBtn;
    public GameObject sTurnBtn;
    public InputActionProperty showMenu;
    public ActionBasedContinuousTurnProvider cTurn;
    public ActionBasedSnapTurnProvider sTurn;
    public XRBaseController rightController;
    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        if (showMenu.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
        if (GlobalVariables.Exit)
        {
            //exit out of testing
            UnityEditor.EditorApplication.isPlaying = false;
            //exit out of built game
            Application.Quit();
        }
        else if (GlobalVariables.SnapTurn)
        {
            sTurnBtn.GetComponent<Renderer>().material = on;
            cTurnBtn.GetComponent<Renderer>().material = off;
            cTurn.enabled = false;
            sTurn.enabled = true;
            rightController.SendHapticImpulse(0.1f, 0.1f);
            GlobalVariables.SnapTurn = false;
        }
        else if (GlobalVariables.ContinousTurn)
        {
            sTurnBtn.GetComponent<Renderer>().material = off;
            cTurnBtn.GetComponent<Renderer>().material = on;
            sTurn.enabled = false;
            cTurn.enabled = true;
            rightController.SendHapticImpulse(0.1f, 0.1f);
            GlobalVariables.ContinousTurn = false;
        }
    }
}
