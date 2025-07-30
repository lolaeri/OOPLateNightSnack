using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhostDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }

    void Update()
    {

    }
}
