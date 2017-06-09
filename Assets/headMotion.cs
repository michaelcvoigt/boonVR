using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headMotion : MonoBehaviour {

	public GameObject TopBar;
	public GameObject MountedBar;
	public GameObject OVRCenter;
	public GameObject CenterRotateForBar;

	// Use this for initialization
	void Start () {
		TopBar.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{

		//Debug.Log(  OVRCenter.transform.rotation.eulerAngles.x );

		if (OVRCenter.transform.rotation.eulerAngles.x < 350 && OVRCenter.transform.rotation.eulerAngles.x > 270  ) {

			TopBar.SetActive(true);
			MountedBar.SetActive(false);

		} else {

			float rotationY = OVRCenter.transform.rotation.eulerAngles.y;
			CenterRotateForBar.transform.eulerAngles = new Vector3(0, rotationY, 0);
			TopBar.SetActive(false);
			MountedBar.SetActive(true);
		}

	}
}
