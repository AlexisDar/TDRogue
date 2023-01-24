using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public GameObject objectToFollow;
    public float speed;

    private float distance;

    private void Awake()
    {
        objectToFollow = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        
    }

    void Update()
    {

        //On récupère la position de l'ennemi et celle de l'objet vers lequel l'ennemi doit se diriger pour obtenir la distance entre les 2 
        distance = Vector2.Distance(transform.position, objectToFollow.transform.position);
        Vector2 direction = objectToFollow.transform.position - transform.position;

        // the player move to the objectToFollow 
        transform.position = Vector2.MoveTowards(this.transform.position, objectToFollow.transform.position, speed * Time.deltaTime);
    }
}
