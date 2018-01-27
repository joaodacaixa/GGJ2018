using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private float _vertical, _horizontal;
	public float velocidade;
	public Animator playeranim;
	public SpriteRenderer playersr;
	private bool _andah,_andahp, _andavp, _andavn;
	private Rigidbody2D _playerRB;
	// Use this for initialization
	void Start () {
		playeranim = GetComponent<Animator> ();
		_playerRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float _horizontal = Input.GetAxisRaw ("Horizontal") * velocidade;
		float _vertical = Input.GetAxisRaw ("Vertical") *  velocidade;
		_playerRB.velocity = new Vector2 (_horizontal, _vertical); 
		if (_horizontal != 0) {
			
				
			if (_horizontal < 0) {
				_andah = true;	
				_andahp = false;	
				playersr.flipX = false;
			}
			if (_horizontal > 0) {
				print (_horizontal);
				_andahp = true;
				_andah = false;	
				playersr.flipX = true;
			} 
		}else {
			_andah = false;
			_andahp = false;	
			//_playerRB.velocity = new Vector2 (0,0);
			}
		if (_vertical != 0) {
			
			if (_vertical > 0) {
				_andavp = true;
				_andavn = false;
			}
			if (_vertical < 0) {
				_andavn = true;
				_andavp = false;
			}
		} else {
			_andavp = false;
			_andavn = false;
		}
			playeranim.SetBool ("andah", _andah);
			playeranim.SetBool ("andahp", _andahp);
			playeranim.SetBool ("andavp", _andavp);
			playeranim.SetBool ("andavn", _andavn);
	}
}

