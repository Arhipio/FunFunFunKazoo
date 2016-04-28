using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	ButtonPress button1;
	ButtonPress button2;
	ButtonPress button3;
	public bool step1;
	public bool step2;
	public bool step3;
	void Start (){
		button1 = GameObject.Find("button").GetComponent<ButtonPress>();
		button2 = GameObject.Find("button 1").GetComponent<ButtonPress>();
		button3 = GameObject.Find("button 2").GetComponent<ButtonPress>();
	}
	// Update is called once per frame
	void Update () {
		if ( button1.button1down&& button2.button1down == false && button3.button1down == false) {
			step1=true;}
		if (button2.button1down&&step1) {
			step2=true;}
		if (button3.button1down && step1&&step2==false) {
			step1=false;}
		if(button3.button1down&&step2){
			step3 =true;
			this.GetComponent<Animator>().SetBool("Door", true);}
	}
}
