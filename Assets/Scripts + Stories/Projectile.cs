using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    private float _speed;
    private bool Upbo;
    private bool Leftbo;
    private bool Rightbo;
    private bool Downbo;
    int scoreValue = Random.Range(0,10);


    void Update()
    {
        if (Input.GetKey("i"))
        {
            Upbo = true;
        }
        if (Input.GetKey("l"))
        {
            Downbo = true;
        }
        if (Input.GetKey("j"))
        {
            Leftbo = true;
        }
        if (Input.GetKey(";"))
        {
            Rightbo = true;
        }
        if (tag == "up")
        {
            if (Upbo == true)
            {
                transform.Translate(Vector3.up * _speed);
            }
        }
        if (tag == "left")
        {
            if (Leftbo == true)
            {
                transform.Translate(Vector3.left * _speed);
            }
        }
        if (tag == "right")
        {
            if (Rightbo == true)
            {
                transform.Translate(Vector3.right * _speed);
            }
        }
        if (tag == "down")
        {
            if (Downbo == true)
            {
                transform.Translate(Vector3.down * _speed);
            }
        }
    }


    public void SetSpeed(float value)
	{
		_speed = value;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("enemy1")) 
		{
			Destroy (other.gameObject);
			Destroy (gameObject);
			ScoreManager.score += scoreValue;
		}
        if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}

