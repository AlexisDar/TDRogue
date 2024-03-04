using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemiParent : MonoBehaviour
{
    public SO_Ennemi SO;

    public float speed;
    public float currentHp;


    public void Awake()
    {
        currentHp = SO.Hp;
    }

    private void OnDestroy()
    {
        WaveManager.instance.enemis.Remove(this);
    }

    public void TakeDamage(float damage)
    {
        currentHp -= damage;
    }
}
