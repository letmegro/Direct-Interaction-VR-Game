using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{

    public string level;

    private void Start()
    {
        GlobalVariables.PlayerHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.PlayerHealth <= 0)
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        GlobalVariables.Reset();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(level);
    }

}
