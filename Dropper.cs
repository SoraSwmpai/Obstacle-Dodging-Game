using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeTowait = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > timeTowait)
        {
            Debug.Log("ehe");
        }
    }
}
