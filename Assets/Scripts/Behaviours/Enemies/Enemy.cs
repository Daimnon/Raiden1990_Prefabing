using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //var
    public float hp = 100;
    public float CurrentHP;
    public float projSpeed = 5f;
    private float _shotCooldown = 0;
    public float FireRate = 1;
    public float animDelay = 0;
    float rTime;
    public EnemyManager manager;
    public Player player;

    //intiate
    [SerializeField] private Transform _enemyGunPos;
    public GameObject projectile;
    private Animator anim;



    void Start()
    {
        CurrentHP = hp;
        anim = gameObject.GetComponent<Animator>();
        rTime = Random.Range(5, 10);
    }


    void Update()
    {
        if (_shotCooldown > 0)
            _shotCooldown -= Time.deltaTime;

        if (_shotCooldown < 0)
            _shotCooldown = 0;

        if (_shotCooldown != 0)
            return;

        _shotCooldown = FireRate / 2;
        GameObject proj = Instantiate(projectile, _enemyGunPos);
    }

    public void Damage(int damage)
    {
        if (CurrentHP <= 0) return;
        CurrentHP -= damage;

        if (CurrentHP <= 0) // enemy died
        {
            anim.Play("Destroy");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + animDelay);
            //player.points += 100;
        }
    }
}