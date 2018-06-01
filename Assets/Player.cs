using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")] [SerializeField] float xSpeed = 4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float yOffset = verticalThrow * xSpeed * Time.deltaTime;
        float xOffset = horizontalThrow * xSpeed * Time.deltaTime;

        float rawXPos = transform.localPosition.x + xOffset;
        float rawYPos = transform.localPosition.y + yOffset;

        rawYPos = Mathf.Clamp(rawYPos, -1.5f, 1.5f);
        rawXPos = Mathf.Clamp(rawXPos, -3f, 3f);

        transform.localPosition = new Vector3(rawXPos, rawYPos, transform.localPosition.z);

	}
}
