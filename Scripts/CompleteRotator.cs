using UnityEngine;
using System.Collections;

public class CompleteRotator : MonoBehaviour {


    //removed the void start because we don't need to initialize 
    //any physical force later called in void Update

	//Update is called every frame
	void Update () 
	{
		//Rotate thet transform of the game object this is attached to by 45 degrees, taking into account the time elapsed since last frame.
        //rotating 45 degrees around the world's Z's axis 
        //https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
        //only using the eulers or rotations needed to affect the pickups
        
	}
}
