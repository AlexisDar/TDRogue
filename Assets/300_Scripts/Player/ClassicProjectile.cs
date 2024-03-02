using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicProjectile : MonoBehaviour
{

    public void Update()
    {
        transform.Translate(new Vector3(1,0,0) * Time.deltaTime);
    }
}
