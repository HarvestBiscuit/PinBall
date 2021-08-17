using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PointController : MonoBehaviour
{
    private GameObject pointText;
    private int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("PointText");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<Text>().text = Convert.ToString(point);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.point += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.point += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.point += 15;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.point += 30;
        }
    }
}
