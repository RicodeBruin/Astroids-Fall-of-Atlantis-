using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerManager : MonoBehaviour {
    private randomSpawning scriptStop;
    private Rigidbody2D _rigidbody;
    public float _lives = 10;
    public float _score = 0;
    private bool endGame;
	private Animator _anim;
    //public Text gameoverText;


	
	void Start ()
	{
        endGame = false;
        _rigidbody = GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator> ();
	}
	

	void Update () {
	if (_lives == 0)
        {
            endGame = true;
            Time.timeScale = 0;
          //  SetCountText();
        }
    if(_lives <= 9)
        {
            Destroy(GameObject.FindGameObjectWithTag("l10"));
        }
        if (_lives <= 8)
        {
            Destroy(GameObject.FindGameObjectWithTag("l9"));
        }
        if (_lives <= 7)
        {
            Destroy(GameObject.FindGameObjectWithTag("l8"));
        }
        if (_lives <= 6)
        {
            Destroy(GameObject.FindGameObjectWithTag("l7"));
        }
        if (_lives <= 5)
        {
            Destroy(GameObject.FindGameObjectWithTag("l6"));
        }
        if (_lives <= 4)
        {
            Destroy(GameObject.FindGameObjectWithTag("l5"));
        }
        if (_lives <= 3)
        {
            Destroy(GameObject.FindGameObjectWithTag("l4"));
        }
        if (_lives <= 2)
        {
            Destroy(GameObject.FindGameObjectWithTag("l3"));
        }
        if (_lives <= 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("l2"));
        }
        if (_lives <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("l1"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!endGame)
        {
            if (other.CompareTag("enemy1"))
            {
                Destroy(other.gameObject);
                _lives -= 1;
                _score += Random.Range(0,500);
				_anim.Play ("Shake");
            }
        }
    }
    //void SetCountText()
    //{
 //
  //          gameoverText.text = "Game Over!";
    //    
    //}
}
