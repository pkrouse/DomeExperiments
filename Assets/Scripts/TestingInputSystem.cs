using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float jumpForce = 6;
    public void Start()
    {
	playerRigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
    	Debug.Log("JUMP!!!");
    	playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}