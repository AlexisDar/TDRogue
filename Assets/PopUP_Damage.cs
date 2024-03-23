using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUP_Damage : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    private float timeBeforeDeseapeared = 1;

    void Update()
    {
        transform.Translate(transform.up * moveSpeed * Time.deltaTime);

        timeBeforeDeseapeared -= Time.deltaTime;

        if (timeBeforeDeseapeared < 0)
        {
            Destroy(gameObject);
        }
    }
}
