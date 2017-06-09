using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {


public Transform cameraTransform = null;

	void LateUpdate () {


		transform.LookAt (cameraTransform.position, -Vector3.right);
}

public void SetCameraTransform( Transform transform ){

cameraTransform = transform;

}


}