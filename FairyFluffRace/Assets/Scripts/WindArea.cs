using UnityEngine;

public class WindArea : MonoBehaviour
{
    [SerializeField] private float windStrength;

    void Awake() {
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //will need refinement
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(Vector2.left * windStrength);
        }
    }
}
