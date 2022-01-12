using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public GameObject ball;
    public GameObject pichachu;
    public Text numTxt;
    int myNum;
    public int pichaNum;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld!!");

        pichaNum = 10;
        numTxt.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        //Debug.Log("Click!!");
        myNum++;

        numTxt.text = myNum.ToString();
        Debug.Log("myNum : " + myNum);
        if(myNum == pichaNum)
        {
            pichachu.SetActive(true);
            ball.SetActive(false);
        }
        else if (myNum != pichaNum)
        {
            pichachu.SetActive(false);
            ball.SetActive(true);
        }
    }
}
