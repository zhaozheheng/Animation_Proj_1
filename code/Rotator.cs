using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rotator : MonoBehaviour {

	//parameter to set original position and oritation
	Vector3 startPoint;
	Quaternion startRotate;

	protected int rotateSpeedX = 90;
	protected int transSpeedX = 2;
	protected int rotateSpeedY = 90;
	protected int transSpeedY = 2;
	protected int rotateSpeedZ = 90;
	protected int transSpeedZ = 2;

	protected int clockDecisionX = 1;
	protected int clockDecisionY = 1;
	protected int clockDecisionZ = 1;

	protected int transDecision = 1;
	//parameter in rotation
	protected bool rotateX = false;
	protected bool rotateY = false;
	protected bool rotateZ = false;
	//parameter in translation
	protected bool transX = false;
	protected bool transY = false;
	protected bool transZ = false;

	protected int reset = 0;
	protected int trans = 0;
	protected int rotate = 1;
	//parameter in decide to translate or rotate in OCS or WCS
	protected Space space;
	protected int sp = 0;
	protected int decideCS = 1;

	void Start(){
		startPoint = transform.position;
		startRotate = transform.rotation;
	}

	void Update(){
		//rotation
		if(trans % 2 == 0){
			if(sp % 2 == 0){
				space = Space.Self;
			}
			if(sp % 2 == 1){
				space = Space.World;
			}
			if (rotateX) {
				transform.Rotate (Time.deltaTime * rotateSpeedX, 0, 0, space);
			}
			if (rotateY) {
				transform.Rotate (0, Time.deltaTime * rotateSpeedY, 0, space);
			}
			if (rotateZ) {
				transform.Rotate (0, 0, Time.deltaTime * rotateSpeedZ, space);
			}
		}
		//translation
		if(trans % 2 == 1){
			if(sp % 2 == 0){
				space = Space.Self;
			}
			if(sp % 2 == 1){
				space = Space.World;
			}
			if(transX){
				transform.Translate (Time.deltaTime * transSpeedX, 0, 0, space);
			}
			if(transY){
				transform.Translate (0, Time.deltaTime * transSpeedY, 0, space);
			}
			if(transZ){
				transform.Translate (0, 0, Time.deltaTime * transSpeedZ, space);
			}
		}
		//chose clock or count-clock on X-Axis
		if(clockDecisionX % 2 == 0){
			GameObject.Find ("X-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "X-Count";
		}
		if(clockDecisionX % 2 == 1){
			GameObject.Find ("X-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "X-Clock";
		}
		//chose clock or count-clock on Y-Axis
		if(clockDecisionY % 2 == 0){
			GameObject.Find ("Y-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Y-Count";
		}
		if(clockDecisionY % 2 == 1){
			GameObject.Find ("Y-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Y- Clock";
		}
		//chose clock or count-clock on Z-Axis
		if(clockDecisionZ % 2 == 0){
			GameObject.Find ("Z-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Z-Count";
		}
		if(clockDecisionZ % 2 == 1){
			GameObject.Find ("Z-Clock").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Z-Clock";
		}
		//chose to translate or rotate in OCS or WCS
		if(decideCS % 2 == 0){
			GameObject.Find ("OCS").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "WCS";
		}
		if(decideCS % 2 == 1){
			GameObject.Find ("OCS").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "OCS";
		}
		//chose to translate or rotate
		if(transDecision % 2 == 0){
			GameObject.Find ("Rotate").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Translate";
		}
		if(transDecision % 2 == 1){
			GameObject.Find ("Rotate").GetComponent<Button> ().GetComponentInChildren<Text> ().text = "Rotate";
		}

	}

	//decide clock or count-clock on X-Axis
	public void TransToCounterClockX(){
		rotateSpeedX = rotateSpeedX * (-1);
		transSpeedX = transSpeedX * (-1);
		clockDecisionX++;
	}
	//decide clock or count-clock on Y-Axis
	public void TransToCounterClockY(){
		rotateSpeedY = rotateSpeedY * (-1);
		transSpeedY = transSpeedY * (-1);
		clockDecisionY++;
	}
	//decide clock or count-clock on Z-Axis
	public void TransToCounterClockZ(){
		rotateSpeedZ = rotateSpeedZ * (-1);
		transSpeedZ = transSpeedZ * (-1);
		clockDecisionZ++;
	}

	//decide translate or rotate
	public void TransBetweenRAndT(){
		transDecision++;
		trans = trans + 1;
		rotate = rotate + 1;
		/*if(trans % 2 == 1){
			rotateX = false;
			rotateY = false;
			rotateZ = false;
		}
		if(rotate % 2 == 1){
			transX = false;
			transY = false;
			transZ = false;
		}*/
	}

	//translate or rotate along X-Axis
	public void CubeRotateX () {
		rotateX = !rotateX;
		transX = !transX;
	}

	//translate or rotate along Y-Axis
	public void CubeRotateY () {
		rotateY = !rotateY;
		transY = !transY;
	}

	//translate or rotate along Z-Axis
	public void CubeRotateZ () {
		rotateZ = !rotateZ;
		transZ = !transZ;
	}
	//decide to translate or rotate in OCS or WCS
	public void CSTrans(){
		sp = sp + 1;
		decideCS++;
	}

	//reset the cube to the original position and oritation
	public void Reset(){
		reset = reset + 1;
		transform.position = startPoint;
		transform.rotation = startRotate;
		if(reset > 0){
			rotateX = false;
			rotateY = false;
			rotateZ = false;
			transX = false;
			transY = false;
			transZ = false;
		}
	}

}
