using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemiParent : MonoBehaviour
{
    public SO_Ennemi SO;

    public float speed;

    public void Awake()
    {

    }

    private void OnDestroy()
    {
        WaveManager.instance.enemis.Remove(this);
    }
}
