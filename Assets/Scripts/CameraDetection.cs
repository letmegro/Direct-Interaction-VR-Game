using System.Collections;
using UnityEngine;
public class CameraDetection : MonoBehaviour
{

    public string sceneEnd;
    public AudioSource shot;

    private void Start()
    {
        shot.playOnAwake = false;
        shot.loop = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalVariables.WeaponAtHand && other.gameObject.tag.Equals("Player"))
        {
            GlobalVariables.PlayerHealth = GlobalVariables.PlayerHealth - 3;
            StartCoroutine("PlayShotSound");
        }
    }

    IEnumerator PlayShotSound()
    {
        yield return new WaitForSeconds(0);
        shot.Play();
    }

}
