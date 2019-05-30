using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour {

    public Transform target;

    public float lerpSpeed = 5;

    public float zOffset = -19;


    public void LateUpdate ()
    {
        var currentPosition = transform.position;

        var targetPosition = new Vector3(target.position.x, currentPosition.y, target.position.z + zOffset);

        transform.position = Vector3.Lerp(currentPosition, targetPosition, Time.deltaTime * lerpSpeed);
	}
}
