using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	public GameObject gameOver;
	private Main main;

	// Use this for initialization
	void Start () 
	{
		main = GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		highScoreText.text = main.highScore.ToString ("00000");
		scoreText.text = main.score.ToString ("00000");
	}
	public void ShowGameOver()
	{
		gameOver.SetActive (true);
	}
}
