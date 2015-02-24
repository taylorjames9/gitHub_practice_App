using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineRenderer_2_script : MonoBehaviour {


	//What am I trying to accomplish?
	//A: I want a line Renderer that extends until it reaches a destination
	//When it reaches it's destination, it pauses, and then it continues


	public List<GameObject> allDestinationStops = new List<GameObject>();
	public bool pause;
	private int thisFrameNum = 1;
	private LineRenderer line;
	public GameObject playHead;
	private Vector3 target;
	public Color c1 = Color.black;
	public Color c2 = Color.black;
	public float speed = 0.01f;


	void Start(){
		line = GetComponent<LineRenderer>();
		//thisFrameNum;
		target = allDestinationStops[thisFrameNum].transform.position;

		//LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		//lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
		//lineRenderer.material = new Material(Shader.Find("Default/Diffuse"));
		//lineRenderer.SetColors(c1, c2);
		//lineRenderer.SetWidth(0.1F, 0.1F);
		lineRenderer.SetVertexCount(allDestinationStops.Count);
		//lineRenderer.useWorldSpace = false;

		/**line = GetComponent<LineRenderer>();
		line.enabled = true;
		line.SetVertexCount(allDestinationStops.Count);**/
		lineRenderer.SetPosition(0, allDestinationStops[0].transform.position);

		//recursiveLineDraw(allDestinationStops[thisFrameNum]);

	}

	void Update(){
		//playHead.transform.position = new Vector3(allDestinationStops[thisFrameNum+1]);
		target = allDestinationStops[thisFrameNum].transform.position;
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		float step = speed * Time.deltaTime;
		playHead.transform.position = Vector3.MoveTowards(playHead.transform.position, target, step);
		lineRenderer.SetPosition(thisFrameNum, playHead.transform.position);

		//if (Mathf.Approximately(1.0F, 10f))
		if(playHead.transform.position.Equals(target)){
			thisFrameNum++;

		}

	}

	//this method takes a new destination draws a line w a while loop and then calls itself
	//with the next destination
	public void recursiveLineDraw(GameObject newDestination){
		float lineMover = allDestinationStops[thisFrameNum].transform.position.x;
		if(thisFrameNum < allDestinationStops.Count && !pause){
			do{
				Debug.Log ("lineMover "+lineMover);
				line.SetPosition(thisFrameNum, playHead.transform.position);

			}
			while(lineMover < allDestinationStops[thisFrameNum].transform.position.x);
			thisFrameNum++;
		}
		//recursiveLineDraw(allDestinationStops[thisFrameNum+1]);
	}
}
