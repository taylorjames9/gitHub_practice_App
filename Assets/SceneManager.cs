using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public GameObject qPrefab;

	private int workState;
	//enum StagesOfProduction {Pre, First, Second, Third, Fourth, Working};

	//These are listed in the order that they will appear. 
	public  List<GameObject> allLinesInGame = new List<GameObject>();
	public  List<GameObject> allQuestionsInGame = new List<GameObject>();
	public  List<GameObject> allDotsInGame = new List<GameObject>();

	public  List<GameObject> allNarrationsInGame = new List<GameObject>();
	public  List<GameObject> allWeirdAnimationsInGame = new List<GameObject>();
	private int currLineSeg;
	private int currQuestionsInGame;
	private int currDotsInGame;

	void OnEnable()
	{
		Debug.Log ("allLinesInGame = "+allLinesInGame.Count);
		TriggerLineFinish.OnLineFinish += NextLineSeg;
	}
	
	
	void OnDisable()
	{
		TriggerLineFinish.OnLineFinish -= NextLineSeg;
	}

	void NextLineSeg()
	{

		//switch to new line Segment
		currLineSeg++;
		Debug.Log ("currLineSeg = "+currLineSeg);
		if(currLineSeg < allLinesInGame.Count){
			allLinesInGame[currLineSeg].SetActive(true);
		}
	}

	void NextQuestion(){
		Debug.Log (" question box should appear ");
		GameObject myQWhole = GameObject.Instantiate(qPrefab) as GameObject;
		//myQWhole.transform.parent = GameObject.Find("Canvas").transform;
		myQWhole.transform.SetParent(GameObject.Find("Canvas").transform);
		myQWhole.GetComponent<RectTransform>().localPosition = new Vector3(-100,-100,0);
		Debug.Log ("myLocalPosition = "+myQWhole.GetComponent<RectTransform>().localPosition);

	}

	void NextDot(){

		//switch on new Question
		currDotsInGame++;
		Debug.Log ("currDot = "+currDotsInGame);
		if(currDotsInGame < allDotsInGame.Count){
			allDotsInGame[currDotsInGame].SetActive(true);
		}

	}
}
