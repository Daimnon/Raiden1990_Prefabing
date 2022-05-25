using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [Header("Player Data Reference")]
    [SerializeField] private DataHandler _playerProjectileDataHandler;

    public void ChangeProjectileData(int desiredProjectileType, GameObject projectile)
    {
        switch ((ProjectileType)desiredProjectileType)
        {
            case ProjectileType.BasicArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.BasicArtillery;
                projectile.GetComponent<SpriteRenderer>().color = Color.white;
                break;
            case ProjectileType.QuickFiringArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.QuickFiringArtillery;
                projectile.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case ProjectileType.ExplosiveShells:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ExplosiveShells;
                projectile.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case ProjectileType.ArmourPiercingShot:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ArmourPiercingShot;
                projectile.GetComponent<SpriteRenderer>().color = Color.cyan;
                break;

            default:
                break;
        }
    }

    public void UpdateProjectile(Projectile projectile)
    {
        projectile.ProjectileType = _playerProjectileDataHandler.PlayerProjectileData.ProjectileType;
        projectile.ProjectilePrefab = _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab;
        projectile.FireRate = _playerProjectileDataHandler.PlayerProjectileData.FireRate;
        projectile.Damage = _playerProjectileDataHandler.PlayerProjectileData.Damage;
        projectile.Quantity = _playerProjectileDataHandler.PlayerProjectileData.Quantity;
    }

    public void FireProjectile(int desiredProjectileType)
    {
        GameObject projectileGO;
        projectileGO = Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, new Vector3(0f, 0f, 1f), Quaternion.identity);
        Projectile projectile = projectileGO.GetComponent<Projectile>();
        UpdateProjectile(projectile);
        ChangeProjectileData(desiredProjectileType, projectileGO);
    }
}
