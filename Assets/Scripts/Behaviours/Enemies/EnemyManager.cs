using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private float speed = 2;
    int move = 1;
    public float topEdge, leftEdge;
    public int enemiesCount;
    public bool lost;

    void Start()
    {
        Enemy[] enemies = GetComponentsInChildren<Enemy>(); // creates a coded enemies counter and manager
        enemiesCount = enemies.Length;
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].manager = this;
        }
    }


    void Update()
    {
        transform.position += new Vector3(0, -move * speed * Time.deltaTime, 0);
        if (move > 0 && transform.position.y > topEdge)
        {
            move *= -1;
        }
        //else if (move < 0 && transform.position.y < leftEdge)
        //{
        //    move *= -1;
        //}
    }

    public void EnemyDestroyed()
    {
        enemiesCount--;
        if (enemiesCount == 0) // while all the enemies in the group have died
        {
            lost = true;
        }
    }
}