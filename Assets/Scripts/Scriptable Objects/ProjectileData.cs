using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProjectileType { BasicArtillery = 0, QuickFiringArtillery = 1, ExplosiveShells = 2, ArmourPiercingShot = 3}

[CreateAssetMenu(fileName = "new ProjectileData", menuName = "Projectile Data", order = 1)]
public class ProjectileData : ScriptableObject
{
    public ProjectileType ProjectileType;
    public Color ProjectileColor;
    public GameObject ProjectilePrefab;
    public float FireRate, Damage;
    public int Quantity;
}
