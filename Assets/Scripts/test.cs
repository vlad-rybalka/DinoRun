using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public bool isCreate;
	public GameObject ground1;
	public GameObject ground2;
	public GameObject groundPrefab;
	private Main main;
	// Use this for initialization
	void Start () 
	{
		main = GameObject.FindGameObjectWithTag ("Main").GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!isCreate & ground1.transform.position.x < -30) 
		{
			ground2 = (GameObject)Instantiate(groundPrefab, ground1.transform.position + new Vector3(79,0,0), ground1.transform.rotation);
			ground2.name = "Ground";
			isCreate = true;
		}
		if (ground1.transform.position.x < -50) 
		{
			Destroy (ground1);
			ground1 = ground2;
			isCreate = false;
		}
	}
}
