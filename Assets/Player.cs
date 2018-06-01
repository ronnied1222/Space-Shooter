using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In ms^-1")] [SerializeField] float speed = 20f;
    [SerializeField] float xRange = 3f;
    [SerializeField] float yRange = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float yOffset = verticalThrow * speed * Time.deltaTime;
        float xOffset = horizontalThrow * speed * Time.deltaTime;

        float rawXPos = transform.localPosition.x + xOffset;
        float rawYPos = transform.localPosition.y + yOffset;

        rawYPos = Mathf.Clamp(rawYPos, -yRange, yRange);
        rawXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

        transform.localPosition = new Vector3(rawXPos, rawYPos, transform.localPosition.z);

	}
}
