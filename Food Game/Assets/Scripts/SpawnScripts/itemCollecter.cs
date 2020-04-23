using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollecter : MonoBehaviour
{
    //public variables
    public Text pattyText; //patty counter text
    public int pattyReq; //how many patties are required
    public Text bunText; //bun counter text
    public int bunReq; //how many buns are required
    public Text cheeseText; //cheese counter text
    public int cheeseReq; //how many cheese are required
    //private variables
    private int pattyCollect = 0; //keeps track of how many patties collected
    private int bunCollect = 0; //keeps track of how many buns collected
    private int cheeseCollect = 0; //keeps track of how many cheese collected

    // Start is called before the first frame update
    void Start()
    {
        pattyText.text = ": " + pattyCollect + "/" + pattyReq;
        bunText.text = ": " + bunCollect + "/" + bunReq;
        cheeseText.text = ": " + cheeseCollect + "/" + cheeseReq;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
