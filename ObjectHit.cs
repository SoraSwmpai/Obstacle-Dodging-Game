using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Someone Just Hit Me!!!");
    }
}





