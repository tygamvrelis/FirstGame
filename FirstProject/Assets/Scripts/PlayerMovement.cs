using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool moveLeft = false;
    private bool moveRight = false;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            moveRight = true;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            moveLeft = true;
        }
    }

    // Physics update
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveRight = false;
        }
        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            moveLeft = false;
        }
    }
}
