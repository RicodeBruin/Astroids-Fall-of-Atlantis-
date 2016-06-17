using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class movement : MonoBehaviour
{
    private Vector2 _movement;
    private Rigidbody2D _rigidbody;
    public float speed = 1;
    private Vector2 _random;
    private Vector2 target = new Vector2(0, 0);




    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _random = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f , 1.0f));
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("linkerkant"))
        {
            FlipLinks();
        }
        if (other.gameObject.CompareTag("rechterkant"))
        {
            FlipRechts();
        }
    }
    void FlipLinks()
    {
        Debug.Log("FlipLinks");
        transform.eulerAngles = new Vector2(0, 180);
    }
    void FlipRechts()
    {
        Debug.Log("FlipRechts");
        transform.eulerAngles = new Vector3(180, 180, 180);
    }

}