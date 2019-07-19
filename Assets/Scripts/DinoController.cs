using UnityEngine;
using System.Collections;

public class DinoController : MonoBehaviour {
	public int force;
	public bool isGround;
	public bool isDown;
	public GameObject dinoDown;

	private Vector2[] arrPoints;

	// Use this for initialization
	void Start () 
	{
		arrPoints = GetComponent<PolygonCollider2D> ().points;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W) & isGround & !isDown) 
		{
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);
		}
		if (Input.GetKeyDown (KeyCode.S) & !isGround) 
		{
			GetComponent<Rigidbody2D> ().AddForce (Vector2.down * force);
		}
		if (transform.position.y > -3.3f) 
		{
			isGround = false;
			GetComponent<Animator>().SetBool ("isGround", isGround);
		}
		if (transform.position.y < -3.3f) 
		{
			isGround = true;
			GetComponent<Animator>().SetBool ("isGround", isGround);
			if (Input.GetKey (KeyCode.S)) 
			{
				isDown = true;
				GetComponent<PolygonCollider2D> ().points = dinoDown.GetComponent<PolygonCollider2D> ().points;
			} 
			else 
			{
				isDown = false;
				GetComponent<PolygonCollider2D> ().points = arrPoints;
			}
			GetComponent<Animator> ().SetBool ("isDown", isDown);
		}
			
	}
}