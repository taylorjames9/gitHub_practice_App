using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CorrectButton_Script : MonoBehaviour {


	//[SerializeField]

	//public Button myButton; 

	void OnMouseDown(){
		Debug.Log ("Should be registering button click");
		BroadcastMessage("resumeMasterSequence()", null);

	}
}
