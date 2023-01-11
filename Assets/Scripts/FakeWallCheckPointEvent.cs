using UnityEngine;

public class FakeWallCheckPointEvent : MonoBehaviour
{
    public GameObject fakeWall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(fakeWall);
        }
        
    }
}
