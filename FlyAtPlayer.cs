using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    Vector3 playerPosition;
    [SerializeField] Transform player; 
    [SerializeField] float projectileSpeed = 0.1f;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
        playerPosition = player.transform.position;
    }
    void Update()
    {
        
        DestroyWhenReached();
        MoveToPlayer();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
    }
}
