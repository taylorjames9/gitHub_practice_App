using UnityEngine;
using System.Collections;

public class TriggerLineFinish : MonoBehaviour {

	public delegate void LineFinishAction();
	public static event LineFinishAction OnLineFinish;

	
	public IEnumerator lineFinish(float delay){
		yield return new WaitForSeconds(delay);
		OnLineFinish();

	}
}
