using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public enum Type
    {
             Ammo
            ,Coin
            ,Grenade
            ,Heart
            ,Weapon
    }

    public Type type;
    public int value;

}