using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProjectileType { BasicArtillery, QuickFiringArtillery, ExplosiveShells, ArmourPiercingShot }

[CreateAssetMenu(fileName = "new ProjectileData", menuName = "Projectile Data", order = 1)]
public class ProjectileData : ScriptableObject
{
    public ProjectileType ProjectileType;
    public GameObject ProjectilePrefab;
    public float FireRate, Damage;
    public int Quantity;
}
