using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonFactory : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Person person1 = new Person()
        {
            Name = "Mario",
            Gender = "Male",
            Age = 26
        };

        Debug.Log(person1.Name);
        Debug.Log(person1.Gender);
        Debug.Log(person1.Age);

        Person person2 = new Person();
        person2.Name = "Peach";
        person2.Gender = "Female";
        person2.Age = 17;

        Debug.Log(person2.Name);
        Debug.Log(person2.Gender);
        Debug.Log(person2.Age);

        person1.DoAging();
        person2.DoAging();

        Debug.Log(person1.Age);
        Debug.Log(person2.Age);
    }
	
	
}
