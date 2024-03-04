using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicProjectile : ProjectileParent
{
    public void Start()
    {
        dmg = 3;
    }

    public void Update()
    {
        transform.Translate(new Vector3(speed,0,0) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out EnnemiParent ennemiParent)) 
        {
            ennemiParent.TakeDamage(dmg);

            Destroy(this.gameObject);
        }
    }
}
