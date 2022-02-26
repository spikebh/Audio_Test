using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour
{

    public Vector3 positionChange, postionChange1, positionChange2, rotateChange;
    private bool harukoTouch, harukoRotate = false;
    private bool flag1, flag2, flag3 = false;


    // Start is called before the first frame update


    private void Movement()
    {
        if (transform.position.y < 0.929)
        {
            transform.position += positionChange;
        }
        else AudioClip(1);
        if (harukoTouch == true && transform.position.y < 1.783 && transform.position.x < -2.657)
        {
            Sleep(3);
            transform.position += postionChange1;
            //Debug.Log("Im flying!!!");

        }
        else if (harukoTouch == true && transform.position.z >= -5.11)
        {
            AudioClip(3);
            if (!harukoRotate) transform.Rotate(rotateChange); harukoRotate = true;
            transform.position += positionChange2;

        }
        if (transform.position.z < -5.11) Destroy(this.gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            harukoTouch = true;
            Debug.Log("OUCCCHHHH!");
            AudioClip(2);

        }
    }


    private void AudioClip(int test)
    {
        switch (test)
        {
            case 1:
                Debug.Log("I SAY AUDIO1");
                flag1 = true;
                break;

            case 2:
                Debug.Log("I SAY AUDIO2");
                flag2 = true;
                break;


            case 3:
                Debug.Log("I SAY AUDIO3");
                flag3 = true;
                break;
        }


    }


    void Sleep(int secs)
    {
        for (int i = 0; i <= 512000 * secs; i++) ;

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //OnCollisionEnter();
    }
}
