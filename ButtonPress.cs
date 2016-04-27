using UnityEngine;
using System.Collections;

public class ButtonPress: MonoBehaviour {
	public bool Button;	// Reference to the animator bool to trigger the state.
	
	private Animator anim;		// Reference to the animator component.
	private GameObject player;
	public bool button1down;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		anim = GetComponent<Animator>();
	}
	
	void OnTriggerEnter (Collider other){
		anim.SetBool("Button", true);
		button1down = true;
	}
	
	void OnTriggerExit (Collider other){
		anim.SetBool("Button", false);
		button1down = false;
	}
}