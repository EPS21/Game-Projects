using UnityEngine;

public class VariablesAndOperations : MonoBehaviour {
    	
	void Start () {
        //myMethod();	
        myMethod2();
	}

    void myMethod()
    {
        //Debug.Log("hello world");
        //string str1;
        //str1 = "hello!";
        //string str2 = "world!";
        //Debug.Log(str1 + str2);

        int x = 5;

        //Debug.Log(x * x);
        //Debug.Log(x / x);        
        //Debug.Log(x - x);

        x = (x * (x - x));
        Debug.Log(x);


    }

    void myMethod2()
    {
        int x = 3;
        int y = 8;

        float result = (float)x / (float)y;
                
        Debug.Log(result);

    }

    
}
