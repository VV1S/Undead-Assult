using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount=10;
    bool canShoot = true;

    public int GetCurrentAmmo()
    {
            return ammoAmount;
    }

    public void ReduceCurrentAmmo()
    {
            ammoAmount --;
    }

}
