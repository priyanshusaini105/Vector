using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity;
    [SerializeField] private float forwardSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D _player;
    private int jumpsRemaining = 2;
    private bool isGrounded = false;
    public Animator _animator;
    private void Start()
    {
        _player = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }

     void FixedUpdate()
    {
        _player.velocity = new Vector2(forwardSpeed, _player.velocity.y);
       _animator.SetBool("jump", !isGrounded);
    }

     void Jump()
    {
        if (jumpsRemaining > 0)
        {
            if (jumpsRemaining == 2 && !isGrounded)
            {
                _player.velocity = new Vector2(_player.velocity.x, 0f);
            }

            _player.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jumpsRemaining--;
        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        // log("Collision Enter");
            isGrounded = true;
            jumpsRemaining = 2;
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        log("Collision Exit");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void log(string msg){
        Debug.Log(msg);
    }
}
}
