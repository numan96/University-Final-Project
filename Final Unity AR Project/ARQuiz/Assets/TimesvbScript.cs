using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class TimesvbScript : MonoBehaviour, IVirtualButtonEventHandler {

	// Use this for initialization
	private GameObject vbTimes;
	// Use this for initialization
	void Start () {

		vbTimes = GameObject.Find ("TimesButton");

		vbTimes.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);


	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {


		Application.LoadLevel ("timesdifficulty");



	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {






	}
}
