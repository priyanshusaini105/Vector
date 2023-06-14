using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private Rigidbody2D _player;

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
        _player.velocity = new Vector2(forwardSpeed,0f);
    }

    private void Jump(){
        Debug.Log("i am jumping");
        _player.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
    }
}
