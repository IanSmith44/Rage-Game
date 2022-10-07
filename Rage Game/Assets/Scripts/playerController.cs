using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class playerController : MonoBehaviour {

	public float speed;
	public float jumpHeight;
	private Rigidbody rb;
	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}
    void Update ()
    {
        if (Input.GetButtonDown("Jump"))
		{
			rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
		}   
		if (Input.GetButtonDown("Reload"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}