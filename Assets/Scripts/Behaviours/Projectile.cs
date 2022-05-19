using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private ProjectileData _playerProjectileDataHandler;

    private ProjectileType _projectileType;
    private GameObject _projectilePrefab;
    private float _fireRate, _damage;
    private int _quantity;

    private void Awake()
    {
        _projectileType = _playerProjectileDataHandler.ProjectileType;
        _projectilePrefab = _playerProjectileDataHandler.ProjectilePrefab;
        _fireRate = _playerProjectileDataHandler.FireRate;
        _damage = _playerProjectileDataHandler.Damage;
        _quantity = _playerProjectileDataHandler.Quantity;
    }

    public void ChangeProjectileData(int desiredProjectileType)
    {
        _playerProjectileDataHandler.ProjectileType = (ProjectileType)desiredProjectileType;

        switch (_playerProjectileDataHandler.ProjectileType)
        {
            case ProjectileType.BasicArtillery:
                _playerProjectileDataHandler = _playerProjectileDataHandler.BasicArtillery;
                _playerProjectileDataHandler.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.white;
                break;
            case ProjectileType.QuickFiringArtillery:
                _playerProjectileDataHandler = _playerProjectileDataHandler.QuickFiringArtillery;
                _playerProjectileDataHandler.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case ProjectileType.ExplosiveShells:
                _playerProjectileDataHandler = _playerProjectileDataHandler.ExplosiveShells;
                _playerProjectileDataHandler.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case ProjectileType.ArmourPiercingShot:
                _playerProjectileDataHandler = _playerProjectileDataHandler.ArmourPiercingShot;
                _playerProjectileDataHandler.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.cyan;
                break;
            default:
                break;
        }
    }
}
