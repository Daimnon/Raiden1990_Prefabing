using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [Header("Player Data Reference")]
    [SerializeField] private DataHandler _playerProjectileDataHandler;

    [Header("Player Guns Positions")]
    [SerializeField] private Transform _playerGunPosition;
    [SerializeField] private Transform _playerSecondaryLeftGunPosition, _playerSecondaryRightGunPosition;

    private float _shotCooldown = 0;

    private void Update()
    {
        FireProjectile();
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

    public void FireProjectile()
    {
        if (_shotCooldown > 0)
            _shotCooldown -= Time.deltaTime;

        if (_shotCooldown < 0)
            _shotCooldown = 0;

        if (_shotCooldown != 0)
            return;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectileGO;
            projectileGO = Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, _playerGunPosition);

            Projectile projectile = projectileGO.GetComponent<Projectile>();
            UpdateProjectile(projectile);

            _shotCooldown = projectile.FireRate / 2;

            for (int i = 0; i < projectile.Quantity - 1; i++)
            {
                if (projectile.Quantity == 3)
                {
                    Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, _playerSecondaryLeftGunPosition);
                    Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, _playerSecondaryRightGunPosition);
                }
            }
        }
    }
}
