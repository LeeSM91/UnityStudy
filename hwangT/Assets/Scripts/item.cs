using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
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
    public int rotate;

    Rigidbody rigit;
    SphereCollider sphereCollider;

    private void Awake()
    {
        rigit = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * rotate * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            rigit.isKinematic = true;
            sphereCollider.enabled = false;
        }
    }

}
