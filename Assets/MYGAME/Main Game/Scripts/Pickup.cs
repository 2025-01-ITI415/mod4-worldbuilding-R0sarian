using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Count_Pick.Instance.IncreaseCount();
            Destroy(gameObject);
        }
    }
}
