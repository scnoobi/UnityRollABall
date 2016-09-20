using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
    public float yRange = 30;
    private float randomYStuff;
     
    void Start()
    {
        randomYStuff = Random.Range(-yRange, yRange);
    }

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (15, randomYStuff, 45) * Time.deltaTime);
	}
}
