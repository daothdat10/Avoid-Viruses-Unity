using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] float speed;
    private Rigidbody2D rb;
    private Vector2 director;
    void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        director = new Vector2(directionX, directionY).normalized;
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(director.x*speed, director.y * speed);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
           explosionParticle.Play();
           
        }
    }
}
