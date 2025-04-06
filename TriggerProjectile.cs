using System;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
        }
    }
}
