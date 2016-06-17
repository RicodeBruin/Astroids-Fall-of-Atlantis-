using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas highscoreMenu;
	//public Canvas optionMenu; 
	public Button startText;
	public Button highscoreText;
	public Button optionText;
	public Button exitText;

	// Verder gaan met highscore menu en options screen ( daarna Tutorial afkijken )
	// Use this for initialization
	void Start () 

	{
		
		//optionMenu = optionMenu.GetComponent<Canvas> ();
		highscoreMenu = highscoreMenu.GetComponent<Canvas> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		highscoreMenu.enabled = false;

	}
	
	public void HighscorePress()
	{
		//
	}

	public void ExitPress()
	{	
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		highscoreText.enabled = false;
		optionText.enabled = false;


	}

	public void NoPress()
	{

		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		highscoreText.enabled = true;
		optionText.enabled = true;
		 

	}

	public void StartLevel ()
	{
	
		SceneManager.LoadScene ("Main");
	
	}

	public void ExitGame()
	{
	
		Application.Quit ();
	
	}
}
