
		using UnityEngine;
		using System.Collections;
		
		public class ButtonPress2: MonoBehaviour {
			public bool Button;	// Reference to the animator bool to trigger the state.
			
			private Animator anim;		// Reference to the animator component.
			private GameObject player;
			public bool button2down;
			
			
			// Use this for initialization
			void Start () {
				
			}
			
			// Update is called once per frame
			void Update () {
				
				anim = GetComponent<Animator>();
			}
			
			void OnTriggerEnter (Collider other){
				anim.SetBool("Button", true);
				button2down = true;
			}
			
			void OnTriggerExit (Collider other){
				anim.SetBool("Button", false);
				button2down = false;
			}
		}


