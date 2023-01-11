
using UnityEngine;

public class bookDrop : MonoBehaviour
{

    public AudioSource dropSound;

    void Start()
    {
        dropSound.loop = false;
        dropSound.playOnAwake = false;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("surface"))
        {
            dropSound.Play();
        }
    }

}
