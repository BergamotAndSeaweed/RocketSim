using UnityEngine;

public class RocketControlScript : MonoBehaviour
{

    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity += new Vector2(0, 10);
        }
    }
}
