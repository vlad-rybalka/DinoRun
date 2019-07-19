using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ground : MonoBehaviour {
	private Main main;
	public List<GameObject> points;
	public List<GameObject> lets;
    public float[] arrayLet = { 1.5f, 2.5f, 3.5f };
	// Use this for initialization
	void Start () 
	{
		main = GameObject.FindGameObjectWithTag ("Main").GetComponent<Main> ();
		if (main.createLets) 
		{
			foreach (GameObject point in points) 
			{
                float moveY = 0;
                int index = Random.Range(0, 5);
                if(index == 4)
                {
                    moveY = arrayLet[Random.Range(0, 3)];
                }
                GameObject let = (GameObject)Instantiate (lets [index], point.transform.position + new Vector3(Random.Range(-4,5),moveY,0), point.transform.rotation);
				let.transform.parent = transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.right * -0.1f * main.speed * Time.timeScale);
	}
}
