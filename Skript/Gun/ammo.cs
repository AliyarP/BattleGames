using System;
using UnityEngine;

public class ammo : MonoBehaviour
{
    [SerializeField] private float _giveammo;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Gun gun))
        {
            gun.GiveAmmo(_giveammo);
            Destroy(gameObject);
        }
    }
    
}
