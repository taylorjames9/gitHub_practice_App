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
		//Debug.Log ("allLinesInGame = "+allLinesInGame.Count);
		//TriggerLineFinish.OnLineFinish += NextLineSeg;
	}
	
	
	void OnDisable()
	{
		//TriggerLineFinish.OnLineFinish -= NextLineSeg;
	}

	public void pauseMasterSequence(){
		GetComponent<Animator>().speed = 0;
	}

	public void resumeMasterSequence(){
		GetComponent<Animator>().speed = 1;
		GameObject.Find(allQuestionsInGame[currQuestionsInGame].name).SetActive (false);

		incrementCurrQuestion();

	}

	public void NextLineSeg()
	{

		//switch to new line Segment
		currLineSeg++;
		Debug.Log ("currLineSeg = "+currLineSeg);
		if(currLineSeg < allLinesInGame.Count){
			allLinesInGame[currLineSeg].SetActive(true);
		}
	}

	public void NextQuestion(){

		pauseMasterSequence();

		if(currQuestionsInGame < allQuestionsInGame.Count){
			allQuestionsInGame[currQuestionsInGame].SetActive(true);
		}

		//currQuestionsInGame++;

		/**This segment of script works for making dynamic buttons
		 * 
		pauseMasterSequence();
		Debug.Log (" question box should appear ");
		GameObject myQWhole = GameObject.Instantiate(qPrefab) as GameObject;
		myQWhole.transform.SetParent(GameObject.Find("Canvas").transform);
		myQWhole.GetComponent<RectTransform>().localPosition = new Vector3(-100,-100,0);
		Debug.Log ("myLocalPosition = "+myQWhole.GetComponent<RectTransform>().localPosition);
		**/



		//myQWhole.transform.FindChild("AnswerB_Button").gameObject.AddComponent<CorrectButton_Script>();
		//GameObject.Find ("AnswerB_Button").AddComponent<CorrectButton_Script>();
		//Button.Find ("AnswerB_Button").onClick
		//var bt = myQWhole.transform.FindChild("AnswerB_Button").GetComponent<Button>();

		//	.onClick.AddListener(() => {resumeMasterSequence();}); 


	}

	public void NextDot(){

		//switch on new Question
		currDotsInGame++;
		Debug.Log ("currDot = "+currDotsInGame);
		if(currDotsInGame < allDotsInGame.Count){
			allDotsInGame[currDotsInGame].SetActive(true);
		}
	}
	public void incrementCurrQuestion(){
		currQuestionsInGame++;
	}

}
