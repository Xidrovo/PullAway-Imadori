using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {

	public static bool guiTouch=false;

	public void TouchInput()
	{
		if (GetComponent<GUITexture>()  !=null) 
		{
			if(GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
			{
				switch(Input.GetTouch(0).phase)
				{
				case TouchPhase.Began:
					SendMessage("OnFirstTouchBegan");
					SendMessage("OnFirstTouch");
					break;
				case TouchPhase.Moved:
					SendMessage("OnFirstTouchMoved");
					SendMessage("OnFirstTouch");

					break;
				case TouchPhase.Stationary:
					SendMessage("OnFirstTouchStayed");
					SendMessage("OnFirstTouch");
					break;
				case TouchPhase.Ended:
					SendMessage("OnFirstTouchEnded");
					guiTouch=false;
					break;
				}
			}
			if(GetComponent<GUITexture>().HitTest(Input.GetTouch(1).position))
			{
				switch(Input.GetTouch(0).phase)
				{
				case TouchPhase.Began:
					SendMessage("OnSecondTouchBegan");
					SendMessage("OnSecondTouch");
					break;
				case TouchPhase.Moved:
					SendMessage("OnSecondTouchMoved");
					SendMessage("OnSecondTouch");
					break;
				case TouchPhase.Stationary:
					SendMessage("OnSecondTouchStayed");
					SendMessage("OnSecondTouch");
					break;
				case TouchPhase.Ended:
					SendMessage("OnSecondtTouchEnded");
					guiTouch=false;
					break;
				}
			}
		}
	}
}
