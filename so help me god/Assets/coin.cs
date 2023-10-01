using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int coinValue = 1; // The value of this coin (you can change this as needed).

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding with the coin has a "Player" tag (you can customize the tag).
        if (other.CompareTag("Player"))
        {
            // Add the coin's value to the player's score.
            GameManager.Instance.AddScore(coinValue);

            // Play a sound effect or perform other actions as needed.
            // Example: AudioSource.PlayClipAtPoint(coinPickupSound, transform.position);

            // Destroy the coin GameObject.
            Destroy(gameObject);
        }
    }
}