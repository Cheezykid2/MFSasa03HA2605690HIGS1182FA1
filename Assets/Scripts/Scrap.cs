using UnityEngine;

public class Scrap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add scrap to the player's inventory
            GameManager playerInventory = other.GetComponent<GameManager>();
            if (playerInventory != null)
            {
                Destroy(gameObject);
            }
        }
    }
}