using UnityEngine;
using System.Collections;

public class PauseGame1 : MonoBehaviour {

    public Transform canvas;
    public Transform player;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            player.GetComponent<PlayerShooting>().enabled = false;
            player.GetComponent<Playermovement>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            player.GetComponent<PlayerShooting>().enabled = true;
            player.GetComponent<Playermovement>().enabled = true;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
