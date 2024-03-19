using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
  public float ForwardForce = 100f;
  public float SideForce = 500f; 

    // Start is called before the first frame update
    void Start()
    {
		// rb.useGravity = false;
      //Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		  rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
      
      if (Input.GetKey("d")){
        rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }
      if (Input.GetKey("a")){
        rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
      }

      if(rb.position.y < -1f){
         StartCoroutine(FindObjectOfType<GameManger>().Endgame());
      }
    }
    
}
