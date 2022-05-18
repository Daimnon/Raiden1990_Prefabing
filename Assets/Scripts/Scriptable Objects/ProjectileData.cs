using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProjectileType { QuickFiringArtillery, ExplosiveShells, ArmourPiercingShot }

[CreateAssetMenu(fileName = "new ProjectileData", menuName = "ScriptableObjects", order = 1)]
public class ProjectileData : ScriptableObject
{
    public ProjectileType ProjectileType;

    private void Awake()
    {
        
    }
}
