using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemiParent : MonoBehaviour
{
    public SO_Ennemi SO;

    public float speed;
    public float currentHp;

    public SpriteRenderer spriteRenderer;

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
        StartCoroutine(ChangeColorWithDmg());
    }

    public IEnumerator ChangeColorWithDmg()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }
}
