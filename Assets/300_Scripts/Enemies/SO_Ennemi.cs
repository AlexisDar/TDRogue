using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemies", menuName = "Ennemies")]
public class SO_Ennemi : ScriptableObject
{
    public int ID;
    public string ennemiName;
    public string description;
    public Sprite icon;

    public float Hp;
    public float DamageBase;
}
