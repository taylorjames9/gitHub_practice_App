using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {


	private int workState;
	//enum StagesOfProduction {Pre, First, Second, Third, Fourth, Working};

	void Start(){
		//StagesOfProduction myStagesOfProduction;
		//myStagesOfProduction = StagesOfProduction.Pre;

	}

	void Update(){
		switch(workState){


			//Case 0 will be the working state. Ie played when the line is drawing
			case 0:
			//draw line
			//play Narration
			//Maybe show bried Animation



			break;

			case 1:
			//Display myQuestionWindow
			//SetMyQuestion.text = " ";
			//Evaluate answer
			//go back to working state (above)


			break;

			case 2:
				
			break;



		}


	}


}
