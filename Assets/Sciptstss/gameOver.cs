using UnityEngine;

using System.Collections;

public class gameOver : MonoBehaviour
{

    private playerManager playerHealth;
    private GameObject atlantis;
    private SpriteRenderer sprite_renderer;

    // Use this for initialization
    void Start()
    {
        sprite_renderer = GetComponent<SpriteRenderer>();
        sprite_renderer.enabled = false;
        atlantis = GameObject.Find("Atlantis");
        playerHealth = atlantis.GetComponent<playerManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth._lives <= 0)
        {
            Time.timeScale = 0;
            sprite_renderer.enabled = true;
            Debug.Log(":)");
        }

    }
}