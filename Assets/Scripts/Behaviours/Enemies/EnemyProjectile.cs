using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] Renderer _selfRenderer;
    [SerializeField] float _projectileSpeed = 1;
    [SerializeField] int _projectileSpeedModifier = 1;

    private GameObject _projectilePrefab;
    private float _fireRate, _damage;

    private void Update()
    {
        if (!_selfRenderer.isVisible)
            Destroy(gameObject);

        transform.parent = null;
        transform.position -= new Vector3(0f, _projectileSpeed / (_projectileSpeedModifier * 10), 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.GetComponent<Player>().CurrentHp -= _damage;
        }
    }
}
