/*
 * Nicolas Korsunski
 * 2022-10-10
 * This script is for loading the next scene and for controlling when and if the player has completed the minimum to move on
 */
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderApartment : MonoBehaviour
{
    public GameObject keyText;
    public string level;
    private void Start()
    {
        keyText.SetActive(false);
    }
    //check if the apartment key has been collected
    private void Update()
    {
        if (GlobalVariables.ApartmentKey)
        {
            keyText.GetComponent<TMPro.TextMeshProUGUI>().text = "The front door is now unlocked";
            keyText.SetActive(true);
            StartCoroutine("DisplayText");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalVariables.ApartmentKey)
        {
            SceneManager.LoadScene(level);

        }
    }
    IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(3);
        Destroy(keyText);
    }

}
