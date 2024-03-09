using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemi_Base : EnnemiParent
{
    private Vector3 target;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        target = PlayerBehavior.Instance.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);

        spriteRenderer.flipX = target.x < transform.position.x; 

        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }

    }

}
