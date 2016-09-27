using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

    private Rigidbody rbody;

	void Start ()
	{

        rbody = GetComponent<Rigidbody>();
        rbody.maxAngularVelocity = 5000;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rbody.AddForce(movement * speed * Time.deltaTime,ForceMode.Impulse);

        rbody.velocity = new Vector3(rbody.velocity.x * 0.99f, rbody.velocity.y,rbody.velocity.z*0.99f);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive (false);
            GameController.instance.TouchedAPickup();
		}
	}
}
