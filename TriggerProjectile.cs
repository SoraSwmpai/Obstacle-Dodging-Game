using System;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject projectile0;
    [SerializeField] private GameObject projectile1;
    [SerializeField] private GameObject projectile2;
    [SerializeField] private GameObject projectile3;
    [SerializeField] private GameObject projectile4;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile0.SetActive(true);
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
        }
    }
}
