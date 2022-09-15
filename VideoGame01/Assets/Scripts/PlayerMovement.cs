using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate() // use fixedupdate when working with physics
    {
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime); // because of dif frame speed on dif comp

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
