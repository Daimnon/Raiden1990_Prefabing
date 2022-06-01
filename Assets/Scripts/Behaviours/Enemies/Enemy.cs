using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //var
    public int hp = 100;
    [SerializeField]
    private int currentHP;
    public float projSpeed = 5f;
    private float fireTime = 2f;
    public float animDelay = 0f;
    float rTime;
    public EnemyManager manager;
    public Player player;

    //intiate
    public Rigidbody2D projectile;
    private Animator anim;



    void Start()
    {
        currentHP = hp;
        anim = gameObject.GetComponent<Animator>();
        rTime = Random.Range(5, 10);
    }


    void Update()
    {

        if (Time.time > fireTime)
        {
            fireTime += rTime;
            Rigidbody2D proj = Instantiate(projectile);
            proj.transform.position = transform.position;
            proj.velocity = Vector2.down * projSpeed;
        }

    }

    public void Damage(int damage)
    {
        if (currentHP <= 0) return;
        currentHP -= damage;

        if (currentHP <= 0) // enemy died
        {
            anim.Play("Destroy");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + animDelay);
            //player.points += 100;
        }
    }
}