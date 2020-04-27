using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  healthpickup : MonoBehaviour

    {
		if(hit.healthItem.tag == "healthpickup")
        {
        Destroy(hit.healthItem);  // Destroys Health Box
        Playerhealth += 50;
        }
       }
