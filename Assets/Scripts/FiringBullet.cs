/*
 * Nicolas Korsunski
 * Last updated: 2022-10-24
 * this script is responsible for the function of a pistol object and all it's sounds and animation(s)
 */
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FiringBullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject brace;
    public Transform spawnPoint;
    public Transform braceEjectPoint;
    public float fireRate = 40;
    public float ejectSpeed = 10;
    public GameObject slide;
    public Transform unloadedPoint;
    public Transform loadedPoint;
    public AudioSource emptyMag;
    public AudioSource reload;
    public AudioSource shot;
    private int maxAmmo = GlobalVariables.MaxAmmo;
    private int ammo;
    private XRGrabInteractable interact;


    void Start()
    {
        //one way to send haptic feedback indirectly via use of custome class
        XRGrabInteractable triggered = GetComponent<XRGrabInteractable>();
        triggered.activated.AddListener(BulletFired);
        ammo = maxAmmo;
        emptyMag.loop = false;
        emptyMag.playOnAwake = false;
        reload.loop = false;
        reload.playOnAwake = false;
        shot.loop = false;
        shot.playOnAwake = false;
        interact = GetComponent<XRGrabInteractable>();
    }
    private void Update()
    {
        if (interact.isSelected)
        {
            GlobalVariables.WeaponAtHand = true;
        }
        else
        {
            GlobalVariables.WeaponAtHand = false;
        }
    }

    public void BulletFired(ActivateEventArgs args)
    {
        if (ammo > 0)
        {
            GameObject spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.transform.rotation = spawnPoint.rotation; 
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireRate;
            ammo -= 1;
            shot.Play();
            GameObject spawnBrace = Instantiate(brace);
            spawnBrace.transform.position = braceEjectPoint.position;
            spawnBrace.transform.rotation = braceEjectPoint.rotation;
            spawnBrace.GetComponent<Rigidbody>().velocity = braceEjectPoint.right * ejectSpeed;
            Destroy(spawnBrace, 4);
            Destroy(spawnedBullet, 2);
        }
        else if (ammo == 0)
        {
            emptyMag.Play();
            slide.transform.position = unloadedPoint.transform.position;
            ammo -= 1;
        }
        else
        {
            emptyMag.Play();
        }
    }
    //reload gun
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("ammo"))
        {
            if (ammo <= 0)
            {
                reload.Play();
                slide.transform.position = loadedPoint.transform.position;
                ammo = maxAmmo;
                Destroy(collision.gameObject);
            }
        }
        
    }

}
