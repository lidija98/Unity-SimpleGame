using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false; // added the PlyerMovement script to movement in unity, now if it hits an obtsacle it stops

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
