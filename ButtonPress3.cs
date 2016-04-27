
using UnityEngine;
using System.Collections;

public class ButtonPress3: MonoBehaviour {
	public bool Button;	// Reference to the animator bool to trigger the state.
	
	private Animator anim;		// Reference to the animator component.
	private GameObject player;
	public bool button3down;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		anim = GetComponent<Animator>();
	}
	
	void OnTriggerEnter (Collider other){
		anim.SetBool("Button", true);
		button3down = true;
	}
	
	void OnTriggerExit (Collider other){
		anim.SetBool("Button", false);
		button3down = false;
	}
}


