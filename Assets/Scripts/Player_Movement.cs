using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float forwardForce = 10f;

    void FixedUpdate()
    { 
        //rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey("d"))
        {   
            rb.AddForce(50*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,100*Time.deltaTime,ForceMode.VelocityChange);
        }

         if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-50*Time.deltaTime,ForceMode.VelocityChange);
        }

          if(Input.GetKey("a"))
        {
            rb.AddForce(-50*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
         if(Input.GetKey("f"))
        {
            rb.AddForce(0,100*Time.deltaTime,0,ForceMode.Impulse);
        }
        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
