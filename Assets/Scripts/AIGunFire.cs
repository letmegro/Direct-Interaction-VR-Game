using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGunFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject brace;
    public Transform spawnPoint;
    public Transform braceEjectPoint;
    public float fireRate = 40;
    public float ejectSpeed = 10;
    public AudioSource shot;
    public float rot;
    private bool canFire;


    void Start()
    {
        shot.loop = false;
        shot.playOnAwake = false;
        canFire = true;
    }

    private void Update()
    {
        if (GlobalVariables.IsPaperReachedFor && GlobalVariables.IsAIWeaponReady && canFire) 
        {
            StartCoroutine(FireGun());
        }
        else if (GlobalVariables.AllEnemiesAttack && canFire)
        {
            StartCoroutine(FireGun());
        }
    }

    public void Fire()
    {
        
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.transform.rotation = spawnPoint.rotation;
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireRate;
            shot.Play();
            GameObject spawnBrace = Instantiate(brace);
            spawnBrace.transform.position = braceEjectPoint.position;
            spawnBrace.transform.rotation = braceEjectPoint.rotation;
            spawnBrace.GetComponent<Rigidbody>().velocity = braceEjectPoint.right * ejectSpeed;
            Destroy(spawnBrace, 4);
            Destroy(spawnedBullet, 2);
        
        
    }

    IEnumerator FireGun()
    {
        canFire = false;
        yield return new WaitForSeconds(rot);
        Fire();
        canFire = true;
        
    }

}
