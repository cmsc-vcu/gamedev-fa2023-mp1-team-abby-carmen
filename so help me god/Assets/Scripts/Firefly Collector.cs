using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.UI;

public class FireflyController : MonoBehaviour
{
    private int firefly = 0;
    [SerializeField] private Text numFirefly;
    [SerializeField] private AudioSource collection;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("triangle"))
        {
            collection.Play();
            Destroy(collision.gameObject);
            firefly++;
            numFirefly.text = "Total Fireflies: " + firefly;
        }
    }
}
