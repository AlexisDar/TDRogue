using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "WeaponCreation")]
public class SO_Weapons : ScriptableObject
{
    public string weaponName;
    public string description;
    public Sprite weaponSprite;
}
