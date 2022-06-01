using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] private CombatManager _combatManager;
    [SerializeField] private DataHandler _playerProjectileDataHandler;
    [SerializeField] private ProjectileType _projectileType;
    [SerializeField] private GameObject _gun;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            switch (_projectileType)
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
                    return;
            }

            Destroy(gameObject);
        }
    }
}
