using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public float speed;
	public float acceleration;
	public float score;
	public float highScore;
	public bool createLets;
	private UI ui;
	// Use this for initialization
	void Start () 
	{
		ui = GetComponent<UI> ();
		Time.timeScale = 1;
		if(PlayerPrefs.HasKey("HighScore"))
		{
			highScore = PlayerPrefs.GetFloat ("HighScore");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		score += speed * Time.deltaTime * 2;
		speed += acceleration;
		if (score > 19) 
		{
			createLets = true;
		}
	}
	public void GameOver()
	{
		if (score > PlayerPrefs.GetFloat ("HighScore")) 
		{
			highScore = score;
			PlayerPrefs.SetFloat ("HighScore", score);
		}
		ui.ShowGameOver();
	}
	public void Restart()
	{
		Application.LoadLevel (0);
	}
}
