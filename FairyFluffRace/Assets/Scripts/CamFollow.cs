using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform fairy;
    [SerializeField] private Vector2 movementTolerance;

    void Awake() 
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fairy == null) return;
        transform.position = new Vector3(transform.position.x, fairy.position.y, transform.position.z);
    }
}
