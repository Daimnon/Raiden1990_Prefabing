using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    [Header("Player Data Reference")]
    private ProjectileData _playerProjectileData;
    public ProjectileData PlayerProjectileData { get => _playerProjectileData; set => _playerProjectileData = value; }

    [Header("Projectile Reference")]

    [Header("Data")]
    public ProjectileData BasicArtillery;
    public ProjectileData ArmourPiercingShot, ExplosiveShells, QuickFiringArtillery;

    public int _powerCount = 0;

    private void Start()
    {
        _playerProjectileData = BasicArtillery;
    }
}
