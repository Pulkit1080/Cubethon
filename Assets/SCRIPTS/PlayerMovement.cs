
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forewardForce = 2000f;
    public float sidewaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forewardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < -0.5f)
          {
            FindObjectOfType<GameManager>().EndGame();
          }
    }
}
