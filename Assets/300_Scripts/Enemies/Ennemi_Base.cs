using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemi_Base : EnnemiParent
{
    public Vector3 target;

    public void Awake()
    {

    }

    public void Start()
    {
    }

    public void Update()
    {
        target = PlayerBehavior.Instance.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime);
    }
}
