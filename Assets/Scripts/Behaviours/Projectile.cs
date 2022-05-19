using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private ProjectileData _playerProjectileData;

    private ProjectileType _projectileType;
    private GameObject _projectilePrefab;
    private float _fireRate, _damage;
    private int _quantity;

    private void Awake()
    {
        _projectileType = _playerProjectileData.ProjectileType;
        _projectilePrefab = _playerProjectileData.ProjectilePrefab;
        _fireRate = _playerProjectileData.FireRate;
        _damage = _playerProjectileData.Damage;
        _quantity = _playerProjectileData.Quantity;
    }

    //private void Update()
    //{
    //    if (_playerProjectileData.ProjectileType == _projectileType)
    //        return;
    //
    //    _projectileType = _playerProjectileData.ProjectileType;
    //    _projectilePrefab = _playerProjectileData.ProjectilePrefab;
    //    _fireRate = _playerProjectileData.FireRate;
    //    _damage = _playerProjectileData.Damage;
    //    _quantity = _playerProjectileData.Quantity;
    //}
}
