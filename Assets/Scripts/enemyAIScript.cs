/*
 * Nicolas Korsunski
 * 2022-11-23
 * 
 */
using System.Collections;
using UnityEngine;

public class enemyAIScript : MonoBehaviour
{
    public Animator AIAnimation;
    public GameObject enemy;
    public Transform player;
    private bool animationReset;
    
    void Update()
    {
        if(GlobalVariables.IsPaperReachedFor && GlobalVariables.IsPaperNotWatched == false || GlobalVariables.AllEnemiesAttack)
        {
            AIAnimation.SetBool("canAim", true);
            StartCoroutine(ReadyGun());
        }
    }
   
    private void LateUpdate()
    {
        if (GlobalVariables.IsPaperReachedFor && GlobalVariables.IsPaperNotWatched == false || GlobalVariables.AllEnemiesAttack)
        {
            if (animationReset == false)
            {
                AIAnimation.Rebind();
                animationReset = true;
            }
            enemy.transform.LookAt(player);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            AIAnimation.SetBool("isDead", true);
            AIAnimation.Rebind();
        }
    }
    IEnumerator ReadyGun()
    {
        yield return new WaitForSeconds(1.2f);
        GlobalVariables.IsAIWeaponReady = true;
    }
}
