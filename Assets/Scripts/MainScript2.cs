using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Math;


public class MainScript2: MonoBehaviour
{

    public float Speed = 600;
    public bool isSpin = true;

    public GameObject pointer;

    public float circle = 360;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateWheel();
    }


    void RotateWheel()
    {
        float circleRotate = Speed * Time.deltaTime;
        transform.Rotate(0, 0, circleRotate);

        if (isSpin == false && Speed > 0)
        {
            Stop();
            circle = circleRotate;


            

        }
        


        Debug.Log(circle);
    }

    public void Stop()
    {
        isSpin = false;

        Speed--;

        
    }

    public static float FindDegree(int x, int y)
    {
        float value = (float)((Mathf.Atan2(x, y) / Math.PI) * 180f);
        if (value < 0) value += 360f;

        return value;

        /*

        if(Speed <= 5)
        {
            pointer.GetComponent<BoxCollider2D>().enabled = true;
        }


        if (Speed <= 0)
        {
            pointer.GetComponent<BoxCollider2D>().enabled = true;
            Speed = 0;
        //    Thread.Sleep(5000);

            //if (isActive == true)

            //{
            //    SceneManager.LoadScene("NoughtsAndCrosses");
            //}



        }
        */


    }
