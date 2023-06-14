using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity;
    [SerializeField] private float forwardSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D _player;
    public bool isGrounded = false;

    private void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {        
        _player.velocity = new Vector2(forwardSpeed, _player.velocity.y);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            _player.velocity = new Vector2(_player.velocity.x, jumpForce);
        }
        else
        {
            _player.velocity = new Vector2(_player.velocity.x, -gravity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
