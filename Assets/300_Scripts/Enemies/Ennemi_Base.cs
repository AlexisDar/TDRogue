using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemi_Base : EnnemiParent
{
    private Vector3 target;

    public void Start()
    {

    }

    public void Update()
    {
        target = PlayerBehavior.Instance.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);
        if (target.x < transform.position.x)
        {
            transform.localScale = new Vector2 (-1,1);
        } else
        {
            transform.localScale = new Vector2 (1,1);
        }

        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }

    }

}
