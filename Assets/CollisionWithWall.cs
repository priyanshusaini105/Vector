using UnityEngine;

public class CollisionWithWall : MonoBehaviour
{
    private Rigidbody2D player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        Log("CollisionWithWall");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FallPlayer();
        }
    }

    void Log(string msg)
    {
        Debug.Log(msg);
    }

    void FallPlayer()
    {
        if (player != null)
        {
            player.velocity = new Vector2(0f, player.velocity.y); // Set the player's velocity in the X direction to 0
            player.constraints = RigidbodyConstraints2D.FreezePositionX; // Freeze the player's position in the X direction
        }
    }
}
