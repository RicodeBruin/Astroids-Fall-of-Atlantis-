using UnityEngine;
using System.Collections;

public class Playermovement : MonoBehaviour {

	private Rigidbody2D _rigidbody;
	public Vector2 _direction;
	public Rigidbody rb;
	public float speed;

	private float rotateLinks;
	private float rotateRechts;
    private bool naarRechts;
    private bool naarLinks;


	void Awake () 
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	void Update () 
	{
		float x = Input.GetAxisRaw ("Horizontal");
		float z = Input.GetAxisRaw ("Vertical");
		_direction = new Vector2 (x, z);

        if(x == 1)
        {
            naarRechts = true;
        }
        else
        {
            naarRechts = false;
        }
        if(x == -1)
        {
            naarLinks = true;
        }
        else
        {
            naarLinks = false;
        }
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector2.up, Vector2.zero);
		float distance;

		if (plane.Raycast (ray, out distance))
		{
			Vector2 point = ray.GetPoint (distance);
			Vector2 adjustedheightpoint = new Vector2 (point.x, transform.position.y);
			transform.LookAt (adjustedheightpoint);
		}

		if (Input.GetKey(KeyCode.D))
		{
			RotateRechts ();
		}

		if (Input.GetKey(KeyCode.A))
		{
			RotateLinks();
		}

	}

	void FixedUpdate()
	{
		Vector2 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition(_rigidbody.position + velocity);
	}

	void RotateLinks()
	{
		transform.eulerAngles = new Vector3(180, 180, 180);
	}

	void RotateRechts()
	{
		transform.eulerAngles = new Vector2(0, 180);
	}
}