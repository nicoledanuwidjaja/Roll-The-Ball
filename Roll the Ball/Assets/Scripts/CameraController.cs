using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// reference to player
	public GameObject player;

	// holds offset value
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate runs after all items are processed
	void LateUpdate () 
	{
		// as player moves, camera is moved to align each frame
		transform.position = player.transform.position + offset;
	}
}
