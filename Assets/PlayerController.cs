using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 5f;
    private Rigidbody2D _player;

    private void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {        
        Debug.Log("i am mov");
        _player.velocity = new Vector2(forwardSpeed,0f);
    }
}
