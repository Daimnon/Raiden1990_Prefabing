using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Renderer _selfRenderer;
    [SerializeField] float _projectileSpeed = 1;
    [SerializeField] int _projectileSpeedModifier = 1;

    private ProjectileType _projectileType;
    private Color _projectileColor;
    private GameObject _projectilePrefab;
    private float _fireRate, _damage;
    private int _quantity;

    public ProjectileType ProjectileType { get => _projectileType; set => _projectileType = value; }
    public Color ProjectileColor { get => _projectileColor; set => _projectileColor = value; }
    public GameObject ProjectilePrefab { get => _projectilePrefab; set => _projectilePrefab = value; }
    public float FireRate { get => _fireRate; set => _fireRate = value; }
    public float Damage { get => _damage; set => _damage = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }

    private void Update()
    {
        if (!_selfRenderer.isVisible)
            Destroy(gameObject);

        transform.position += new Vector3(0f, _projectileSpeed / (_projectileSpeedModifier * 10), 0f);
    }
}
