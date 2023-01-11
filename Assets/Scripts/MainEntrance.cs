/*
 * Nicolas Korsunski
 * 2022-10-10
 * This script is used to manage the front entrance/exit
 */
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainEntrance : MonoBehaviour
{
    public string sceneExit;

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalVariables.SecretDoc)
        {
            SceneManager.LoadScene(sceneExit);
        }
    }
}
