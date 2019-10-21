﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickyBall: MonoBehaviour {

  // get input for the facing angle
  public float facingAngle = 0;

  // get input for the x and z for the ball
  float x = 0;
  float z = 0;

  Vector2 unitv2;

  public GameObject cameraReference;
  float distanceToCamera = 5;

  // ball size, starting at 1
  float size = 1;

  // adding different groups
  public GameObject group1;
  bool group1Unlocked = false;

  public GameObject group2;
  bool group2Unlocked = false;

  public GameObject group3;
  bool group3Unlocked = false;

  public GameObject group4;
  bool group4Unlocked = false;

    public GameObject group5;
  bool group5Unlocked = false;

  public GameObject group6;
  bool group6Unlocked = false;

    public GameObject group7;
  bool group7Unlocked = false;

   public GameObject group8;
  bool group8Unlocked = false;

   public GameObject group9;
  bool group9Unlocked = false;

   public GameObject group10;
  bool group10Unlocked = false;

   public GameObject group11;
  bool group11Unlocked = false;

  // Pickup Sound Referenc
  public AudioClip pickupSound;

  public GameObject sizeUI;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

	// user controls
	x = Input.GetAxis("Horizontal") * Time.deltaTime * -100;
	z = Input.GetAxis("Vertical") * Time.deltaTime * 500;

	// Facing Angle
	facingAngle += x;
	unitv2 = new Vector2(Mathf.Cos(facingAngle * Mathf.Deg2Rad), Mathf.Sin(facingAngle * Mathf.Deg2Rad));

  }

  private void FixedUpdate() {

	// Apply force behind the ball
	this.transform.GetComponent < Rigidbody > ().AddForce(new Vector3(unitv2.x, 0, unitv2.y) * z * 3);

	// Set Camera Position Behidn the Ball based on rotation
	cameraReference.transform.position = new Vector3(-unitv2.x * distanceToCamera, distanceToCamera, -unitv2.y * distanceToCamera) + this.transform.position;

	unlockPickupGroups();

  }

// User-defined function that contains boolean expression for the three groups
    
  void unlockPickupGroups()
  {
	if (group1Unlocked == false) {

  	if (size >= 1) {
    	group1Unlocked = true;
    	for (int i = 0; i < group1.transform.childCount; i++) {
      	group1.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
    	}
  	}
	} else if (group2Unlocked == false) {

  	if (size >= 1.5f) {
    	group2Unlocked = true;
    	for (int i = 0; i < group2.transform.childCount; i++) {
      	group2.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
    	}
    	// Change distance between camera and ball
    	distanceToCamera = 6;
  	}
	} else if (group3Unlocked == false) {

  	if (size >= 2f) {
    	group3Unlocked = true;
    	for (int i = 0; i < group3.transform.childCount; i++) {
      	group3.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 6.3f;
	  }	
	} else if (group4Unlocked == false) {

  	if (size >= 3.5f) {
    	group4Unlocked = true;
    	for (int i = 0; i < group4.transform.childCount; i++) {
      	group4.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 6.6f;
    	}


} else if (group5Unlocked == false) {

  	if (size >= 4f) {
    	group5Unlocked = true;
    	for (int i = 0; i < group5.transform.childCount; i++) {
      	group5.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
    	// Change distance between camera and ball
		}
    	distanceToCamera = 6.9f;
    	}
	  

} else if (group6Unlocked == false) {

  	if (size >= 4.5f) {
    	group6Unlocked = true;
    	for (int i = 0; i < group6.transform.childCount; i++) {
      	group6.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 7.2f;
    	}
} else if (group7Unlocked == false) {

  	if (size >= 5f) {
    	group7Unlocked = true;
    	for (int i = 0; i < group7.transform.childCount; i++) {
      	group7.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 7.5f;
    	}
} else if (group8Unlocked == false) {

  	if (size >= 5.5f) {
    	group8Unlocked = true;
    	for (int i = 0; i < group8.transform.childCount; i++) {
      	group8.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 7.8f;
		}
} else if (group9Unlocked == false) {

  	if (size >= 6f) {
    	group9Unlocked = true;
    	for (int i = 0; i < group9.transform.childCount; i++) {
      	group9.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 6.1f;
		}
} else if (group10Unlocked == false) {

  	if (size >= 6.5f) {
    	group10Unlocked = true;
    	for (int i = 0; i < group10.transform.childCount; i++) {
      	group10.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 6.4f;
		}
} else if (group11Unlocked == false) {

  	if (size >= 7f) {
    	group8Unlocked = true;
    	for (int i = 0; i < group8.transform.childCount; i++) {
      	group8.transform.GetChild(i).GetComponent < Collider > ().isTrigger = true;
		}
    	// Change distance between camera and ball
    	distanceToCamera = 6.7f;
  	}
	}
  }
    
  // Pick up Sticky Objects
  // OnTriggerEnter is a commonly used unity function that gets called when an object collides with a trigger
  // Collider refers to the sticky ball (player)
  private void OnTriggerEnter(Collider other) {
	if (other.transform.CompareTag("Sticky")) {
  	if (0 < size) {

    	// Grow the Sticky Ball
    	transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    	size += 0.1f;

    	// Disable so that the objects will only stick to your sphere
    	other.enabled = false;

    	// Becomes Child so it stays with the ball
    	other.transform.SetParent(this.transform);

    	// Create text in the public GameObject sizeUI. Math.Round rounds off the sticky ball size to one decimals
    	sizeUI.GetComponent<Text>().text = "Mass: " + Math.Round(size, 2).ToString();

    	// Sound effect when we Pick up a Sticky Object
    	this.GetComponent<AudioSource>().PlayOneShot(pickupSound);

    	// Print to Console, works like println () in Processing or print() in p5
    	Debug.Log(size);
     	 
  	}
	}
  }
}
