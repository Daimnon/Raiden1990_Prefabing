using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //[SerializeField] private DataHandler _playerProjectileDataHandler;

    private ProjectileType _projectileType;
    private GameObject _projectilePrefab;
    private float _fireRate, _damage;
    private int _quantity;

    public ProjectileType ProjectileType { get => _projectileType; set => _projectileType = value; }
    public GameObject ProjectilePrefab { get => _projectilePrefab; set => _projectilePrefab = value; }
    public float FireRate { get => _fireRate; set => _fireRate = value; }
    public float Damage { get => _damage; set => _damage = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }

    private void Awake()
    {
        //_projectileType = _playerProjectileDataHandler.PlayerProjectileData.ProjectileType;
        //_projectilePrefab = _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab;
        //_fireRate = _playerProjectileDataHandler.PlayerProjectileData.FireRate;
        //_damage = _playerProjectileDataHandler.PlayerProjectileData.Damage;
        //_quantity = _playerProjectileDataHandler.PlayerProjectileData.Quantity;
    }

    public void UpdateProjectile()
    {
        //_projectileType = _playerProjectileDataHandler.PlayerProjectileData.ProjectileType;
        //_projectilePrefab = _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab;
        //_fireRate = _playerProjectileDataHandler.PlayerProjectileData.FireRate;
        //_damage = _playerProjectileDataHandler.PlayerProjectileData.Damage;
        //_quantity = _playerProjectileDataHandler.PlayerProjectileData.Quantity;
    }

    //public void ChangeProjectileData(int desiredProjectileType)
    //{
    //    switch (_playerProjectileDataHandler.PlayerProjectileData.ProjectileType)
    //    {
    //        case ProjectileType.BasicArtillery:
    //            _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.BasicArtillery;
    //            _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.white;
    //            break;
    //        case ProjectileType.QuickFiringArtillery:
    //            _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.QuickFiringArtillery;
    //            _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.green;
    //            break;
    //        case ProjectileType.ExplosiveShells:
    //            _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ExplosiveShells;
    //            _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.red;
    //            break;
    //        case ProjectileType.ArmourPiercingShot:
    //            _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ArmourPiercingShot;
    //            _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.cyan;
    //            break;
    //
    //        default:
    //            break;
    //    }
    //}
}
