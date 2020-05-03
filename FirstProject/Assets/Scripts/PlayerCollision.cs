using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
