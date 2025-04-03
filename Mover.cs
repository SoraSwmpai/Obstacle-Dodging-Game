using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.4f;
    [SerializeField] float zValue = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
