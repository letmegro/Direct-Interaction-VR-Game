using System.Collections;
using UnityEngine;

public class LachlanKingController : MonoBehaviour
{
    public Animator AIAnimation;
    public GameObject enemy;
    public GameObject gun;
    public Transform player;
    private bool animationReset;

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.HeadOfficeEntered && GlobalVariables.IsKingDistracted == false)
        {
            gun.SetActive(true);
            AIAnimation.SetBool("aim", true);
        }
        else if (GlobalVariables.IsKingDistracted)
        {
            //hide character (character was called into a meeting via computer)
            enemy.SetActive(false);
        }
    }
    private void LateUpdate()
    {
        if (GlobalVariables.HeadOfficeEntered && GlobalVariables.IsKingDistracted == false)
        {
            if (animationReset == false)
            {
                AIAnimation.Rebind();
                animationReset = true;
                StartCoroutine(fire());
            }
            enemy.transform.LookAt(player);
        }
        else if (GlobalVariables.IsKingDistracted)
        {
            if (animationReset == false)
            {
                AIAnimation.Rebind();
                animationReset = true;
            }
            }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("bullet"))
        {
            Destroy(enemy);
        }
    }

    IEnumerator fire()
    {
        yield return new WaitForSeconds(1.2f);
        GlobalVariables.AllEnemiesAttack = true;
    }

}
