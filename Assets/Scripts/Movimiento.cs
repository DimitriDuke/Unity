using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2D;
    private bool isGrounded = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if ((Input.GetKeyDown(KeyCode.W)) && isGrounded)
        {
            rb2D.linearVelocity = Vector2.up * speed;
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.contacts[0].normal == Vector2.up)
        {
            isGrounded = true;
        }
    }

    
}
