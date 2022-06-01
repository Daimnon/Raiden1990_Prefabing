using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIProjectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //condition if i hit the player
        if (coll.CompareTag("Player"))
        {
            Player player = coll.GetComponent<Player>();
            player.Damage();
            Destroy(gameObject);
        }
    }
}
