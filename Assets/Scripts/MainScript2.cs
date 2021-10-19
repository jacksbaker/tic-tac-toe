using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class MainScript2: MonoBehaviour
{

    public float Speed = 600;
    public bool isSpin = true;

    public GameObject pointer;

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
        transform.Rotate(0, 0, Speed * Time.deltaTime);

        if (isSpin == false && Speed > 0)
        {
            Stop();
        }
    }

    public void Stop()
    {
        isSpin = false;

        Speed--;

        if (Speed == 1)
        {
            pointer.GetComponent<BoxCollider2D>().enabled = true;
            Speed = 0;
            Thread.Sleep(5000);
            SceneManager.LoadScene("NoughtsAndCrosses");
           
        }
    }

}
