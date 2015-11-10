using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	/// <summary>
	/// The offset vector for a follow camra that is a fixed distance away from the player.
	/// </summary>
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after update is done processing
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}