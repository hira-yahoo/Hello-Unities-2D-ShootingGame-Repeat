﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour {

	public int speed = 10;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up.normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
