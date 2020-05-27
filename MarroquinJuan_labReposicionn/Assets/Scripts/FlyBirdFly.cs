using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBirdFly : MonoBehaviour
{
    public Death manager;
    public float velocity;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        manager.GameOver();
    }
}
