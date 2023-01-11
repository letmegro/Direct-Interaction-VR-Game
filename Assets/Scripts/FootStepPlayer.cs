/*
 * Nicolas Korsunski
 * 2022-10-05
 * this script is for controlling the players foot step sound
 */
using UnityEngine;
using UnityEngine.InputSystem;
//To-Do: clean up script

public class FootStepPlayer : MonoBehaviour
{
    public AudioSource footSteps;
    public InputActionProperty actionMove;
    private bool moving;
    private bool played;
    private Vector2 neutralPosition;
    private Vector2 position;

    void Start()
    {
        neutralPosition = actionMove.action.ReadValue<Vector2>();
        position = actionMove.action.ReadValue<Vector2>();
    }

    void Update()
    {
        if (neutralPosition != position)
        {
            moving = true;
            if(played == false && moving == true)
            {
                footSteps.Play();
                footSteps.loop = true;
                played = true;
            }
            
        }
        else
        {
            if(played == true && moving == false)
            {
                footSteps.Stop();
                footSteps.loop = false;
                played = false;
            }
            moving = false;
            
        }
        position = actionMove.action.ReadValue<Vector2>();

    }
}
