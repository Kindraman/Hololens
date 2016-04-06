using UnityEngine;
using System.Collections;

public class RuedaMuevete : MonoBehaviour {

	public Rigidbody ruedita;
	// Use this for initialization
	void Start () {
		ruedita.velocity = new Vector3 (10, 0, 0);// * Time.time;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	
	}
}
