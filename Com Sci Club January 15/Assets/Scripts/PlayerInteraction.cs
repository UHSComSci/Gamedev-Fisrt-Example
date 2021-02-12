using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    public Rigidbody rb;
    public Movement movement;
    public Transform explosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I collided with " + collision.collider.gameObject.name);
        if(collision.collider.gameObject.layer == 8)
        {
            rb.AddExplosionForce(2000, collision.GetContact(0).point, 10);
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

            //Instantiate(explosionEffect, collision.GetContact(0).point, Quaternion.identity);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            FindObjectOfType<GameManager>().FinishedGame();
        }
    }

}
