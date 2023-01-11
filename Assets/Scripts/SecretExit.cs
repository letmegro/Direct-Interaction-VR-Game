/*
 * Nicolas Korsunski
 * 2022-10-10
 * This script is for controlling the underground door and notifying the player that it is unlocked
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretExit : MonoBehaviour
{
    public string sceneExit;

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalVariables.SecretKey && GlobalVariables.SecretDoc)
        {
            SceneManager.LoadScene(sceneExit);

        }
    }
}
