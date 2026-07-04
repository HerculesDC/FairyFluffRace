using UnityEngine;

public class FuzzBehaviour : MonoBehaviour
{
    [SerializeField] private float drag;
    private Rigidbody2D m_rb;

    void Awake() {
        m_rb = GetComponent<Rigidbody2D>();
        //m_rb.linearDamping = drag;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
