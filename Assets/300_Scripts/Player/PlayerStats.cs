using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats Instance;

    public float curretHp;
    public float maxHp;

    public float moveSpeed;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
