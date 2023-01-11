using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyAIScript : MonoBehaviour
{
    public GameObject medicine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("medicine"))
        {
            GlobalVariables.MedicineGiven = true;
            Destroy(medicine);
        }
    }

}
