using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class VRAutoWalk : MonoBehaviour {
    public float speed = 3.0F;
    public bool moveForward;
    private CharacterController controller;
    private Cardboard gvrViewer;
    private Transform vrHead;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        gvrViewer = transform.GetChild(0).GetComponent<Cardboard>();
        vrHead = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            moveForward = !moveForward;
        }

        if(moveForward)
        {
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }
	}
}
