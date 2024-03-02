using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public static PlayerBehavior Instance;

    public GameObject baseRotateWeapon;
    public GameObject canonWeapon;

    public GameObject bullet;

    public Camera mainCamera;



    public float angle;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Start()
    {

    }

    public void Update()
    {
        transform.Translate(InputManager.Instance.moveValue * PlayerStats.Instance.moveSpeed * Time.deltaTime);

        Vector3 projectedMousePosition = mainCamera.ScreenToWorldPoint(InputManager.Instance.mousePos);

        Vector3 aimDirection = (projectedMousePosition - transform.position).normalized;
        angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        baseRotateWeapon.transform.eulerAngles = new Vector3(0, 0, angle);
    }

    public void Shoot()
    {
        Instantiate(bullet, canonWeapon.transform.position, canonWeapon.transform.rotation);
    }
}
