using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [Header("Player Data Reference")]
    [SerializeField] private DataHandler _playerProjectileDataHandler;

    [SerializeField] private Transform _gunPosition;

    private void Update()
    {
        //if (_playerProjectileDataHandler.IsProjectileChanged)
        //    UpdateProjectile(projectile);
    }

    public void ChangeProjectileData(int desiredProjectileType, GameObject projectile)
    {
        switch ((ProjectileType)desiredProjectileType)
        {
            case ProjectileType.BasicArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.BasicArtillery;
                break;
            case ProjectileType.QuickFiringArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.QuickFiringArtillery;
                break;
            case ProjectileType.ExplosiveShells:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ExplosiveShells;
                break;
            case ProjectileType.ArmourPiercingShot:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ArmourPiercingShot;
                break;

            default:
                break;
        }

        projectile.GetComponent<SpriteRenderer>().color = _playerProjectileDataHandler.PlayerProjectileData.ProjectileColor;
    }

    public void UpdateProjectile(Projectile projectile)
    {
        projectile.ProjectileType = _playerProjectileDataHandler.PlayerProjectileData.ProjectileType;
        projectile.ProjectileColor = _playerProjectileDataHandler.PlayerProjectileData.ProjectileColor;
        projectile.ProjectilePrefab = _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab;
        projectile.FireRate = _playerProjectileDataHandler.PlayerProjectileData.FireRate;
        projectile.Damage = _playerProjectileDataHandler.PlayerProjectileData.Damage;
        projectile.Quantity = _playerProjectileDataHandler.PlayerProjectileData.Quantity;
        
    }

    public void FireProjectile(int desiredProjectileType)
    {
        GameObject projectileGO;
        projectileGO = Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, _gunPosition);
        Projectile projectile = projectileGO.GetComponent<Projectile>();
        UpdateProjectile(projectile);
        //ChangeProjectileData(desiredProjectileType, projectileGO);
    }
}
