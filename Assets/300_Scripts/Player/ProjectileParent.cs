using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProjectileParent : MonoBehaviour
{
    public float speed;
    public float dmg;
    public GameObject popUp;


    public void PopUpDamage(float PopUpText)
    {
        GameObject dmgPopUp = Instantiate(popUp, transform.localPosition, Quaternion.identity);

        dmgPopUp.GetComponent<TextMeshPro>().text = PopUpText.ToString();
    }
}
