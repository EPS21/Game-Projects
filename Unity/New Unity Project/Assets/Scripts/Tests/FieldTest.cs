using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTest : MonoBehaviour
{
    string Message = "Hello";

	// Use this for initialization
	void Start ()
    {
        Debug.Log(Message);
        Method();
        Debug.Log(Message);
        Method();
        Debug.Log(Message);
    }
	
	void Method()
    {
        Message = Message + " World";
    }
}
