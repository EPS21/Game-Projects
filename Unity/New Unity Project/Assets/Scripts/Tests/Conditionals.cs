using UnityEngine;

public class Conditionals : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StateHandler();
	}
	
    void StateHandler ()
    {
        int damageRating; // default
        bool isInvincible = false; // default
        bool grabbedPowerUp = false; // default        
        
        //grabbedPowerUp = false;

        if (grabbedPowerUp)
            isInvincible = true;
        else
            isInvincible = false;

        if (isInvincible)
        {
            damageRating = 0;
            // todo - put in a countdown timer conditional
        }
        else
        {
            damageRating = 100;
        }

        Debug.Log(isInvincible);
        Debug.Log(damageRating);
    }

	void RunConditionals ()
    {
        // int size: -2,147,483,648 to 2,147,483,647
        //int minInt = -2147483648;
        //int minInt1 = int.MinValue;
        int x = 100;

        if (x >= 100)
        {
            Debug.Log(x + " is greater than or equal to 100");
        }
        else
        {
            Debug.Log(x + " is less than 100");
        }

        //if (x == 100)
        //{
        //    Debug.Log("The operands are equivalent");
        //}
        //else if (x == 100 / 2)
        //{
        //    Debug.Log("X is equivalent to 1/2 of 100");
        //}
        //else
        //{
        //    Debug.Log("the ops not equivalent");
        //}
	}

    void RunConditionals3 ()
    {
        bool val = true;

        if (!val)
        {           
            Debug.Log(val.ToString());
        }
        else
        {
            val = false;
            Debug.Log(val.ToString());
        }
    }

    void RunConditionals4 ()
    {
        bool val = true;

        val = !val;
        Debug.Log(val);

        val = !val;
        Debug.Log(val);

        val = !val;
        Debug.Log(val);
    }

    void RunConditionals5 ()
    {
        // simulate button being pressed
        bool isButtonAPressed = true;
        bool isButtonBPressed = true;

        if (isButtonAPressed) 
        {
            Debug.Log("Button A pressed");
            if (isButtonBPressed)
            {
                Debug.Log("Button A and B evaluate as true");
            }
        }
        else
        {
            Debug.Log("button con evaluates as false");
        }
    }
}
