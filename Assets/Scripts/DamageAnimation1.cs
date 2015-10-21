
	using UnityEngine;
	using System.Collections;
	
	public class DamageAnimation1 : MonoBehaviour {

	Animator animator;

	/*	
		public float walkSpeed = 1; // player left right walk speed
		private bool _isGrounded = true; // is player on the ground?
		
		Animator animator;
		
		//some flags to check when certain animations are playing
		bool _isPlaying_crouch = false;
		bool _isPlaying_walk = false;
		bool _isPlaying_hadooken = false;
	*/	
		//animation states - the values in the animator conditions
		const int STATE_Arms = 0;
		const int STATE_Damage = 1;
	

		int _currentAnimationState = STATE_Arms;
		
		// Use this for initialization
		void Start()
		{
			//define the animator attached to the player
			animator = this.GetComponent<Animator>();
		}





		// OnCollision is used to handle gas
	void OnCollisionEnter (Collision col)
		{
			//Check for keyboard input
		if(col.gameObject.name == "Gas")
			{
			Destroy(col.gameObject);
			}


		}
		//--------------------------------------
		// Change the players animation state
		//--------------------------------------
		void changeState(int state){
			
			if (_currentAnimationState == state)
				return;
			
			switch (state) {
				
			case STATE_Arms:
				animator.SetInteger ("state", STATE_Arms);
				break;
				
			case STATE_Damage:
				animator.SetInteger ("state", STATE_Damage);
				break;
				
		
			}
			
			_currentAnimationState = state;
		}
	/*
		//--------------------------------------
		// Check if player has collided with the floor
		//--------------------------------------
		void OnCollisionEnter2D(Collision2D coll)
		{
			if (coll.gameObject.name == "Floor")
			{
				_isGrounded = true;
				changeState(STATE_IDLE);
				
			}
			
		}
	*/	
		//--------------------------------------
		// Flip player sprite for left/right walking
		//--------------------------------------

	/*
	void changeDirection(string direction)
		{
			
			if (_currentDirection != direction)
			{
				if (direction == "right")
				{
					transform.Rotate (0, 180, 0);
					_currentDirection = "right";
				}
				else if (direction == "left")
				{
					transform.Rotate (0, -180, 0);
					_currentDirection = "left";
				}
			}
			
		}
	*/
	}
