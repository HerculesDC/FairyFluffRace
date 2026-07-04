using UnityEngine;

public class StemBehaviour : MonoBehaviour
{
    [SerializeField] private float anchorDistance;

    void Awake()
    {
        GetComponent<Rigidbody2D>().linearDamping = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name != "Fairy") return;
        //will need refinement
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            var temp = gameObject.AddComponent<HingeJoint2D>();
            temp.anchor = Vector2.down*anchorDistance;
            temp.connectedBody = rb;
        }
    }
}
