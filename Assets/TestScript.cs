using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject scoreText;
    public float speed;
    public Text countText;
    public Text winText;
    public Text movementText;

    private Rigidbody rb;
    private int count;
    private int Movement;



    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "SpaceBar : 0";



    }

    // Update is called once per frame
    void Update()
    {
        while (count < 10)
        {
            if (Input.GetKeyDown("space"))
            {
                print("space key was pressed");
                scoreText.GetComponent<Text>().text = " " + count.ToString();
            }



        }


    }
}
