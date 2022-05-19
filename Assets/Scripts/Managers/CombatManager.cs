using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [Header("Player Data Reference")]
    [SerializeField] private DataHandler _playerProjectileDataHandler;

    private Projectile _projectile;

    public void ChangeProjectileData(int desiredProjectileType)
    {
        _playerProjectileDataHandler.PlayerProjectileData.ProjectileType = (ProjectileType)desiredProjectileType;

        switch (_playerProjectileDataHandler.PlayerProjectileData.ProjectileType)
        {
            case ProjectileType.BasicArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.BasicArtillery;
                _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.white;
                break;
            case ProjectileType.QuickFiringArtillery:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.QuickFiringArtillery;
                _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case ProjectileType.ExplosiveShells:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ExplosiveShells;
                _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case ProjectileType.ArmourPiercingShot:
                _playerProjectileDataHandler.PlayerProjectileData = _playerProjectileDataHandler.ArmourPiercingShot;
                _playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab.GetComponent<SpriteRenderer>().color = Color.cyan;
                break;
            default:
                break;
        }
    }

    public void FireProjectile()
    {
        Instantiate(_playerProjectileDataHandler.PlayerProjectileData.ProjectilePrefab, new Vector3(0f, 0f, 1f), Quaternion.identity);
    }
}
