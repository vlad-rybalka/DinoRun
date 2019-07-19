using UnityEngine;
using System.Collections;

public class let : MonoBehaviour {
	private Main main;

	// Use this for initialization
	void Start () 
	{
		main = GameObject.FindGameObjectWithTag ("Main").GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		main.GameOver();
		Time.timeScale = 0;
	}
}
