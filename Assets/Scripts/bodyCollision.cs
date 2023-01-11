/*
 * Nicolas Korsunski
 * 2022-11-21
 * Player body collision script
 */
using UnityEngine;

public class bodyCollision : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("bullet"))
        {
            GlobalVariables.PlayerHealth -= 3;
        }
    }


}
