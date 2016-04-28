using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	ButtonPress button1;
	ButtonPress2 button2;
	ButtonPress3 button3;
	public bool step1;
	public bool step2;
	public bool step3;

	void Start (){
		button1 =new ButtonPress();
		button2 = new ButtonPress2();
		button3 = new ButtonPress3();
	}
	// Update is called once per frame
	void Update () {
		if ( button1.button1down&& button2.button2down == false && button3.button3down == false) {
			step1=true;
		}
		if (button2.button2down&&step1) {
			step2=true;
		}
		if (button3.button3down && step1) {
			step1=false;}

		if(button3.button3down&&step2){
			step3 =true;}}
}
