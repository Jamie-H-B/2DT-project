using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 0;
        string playerName = "James";
        float jumpForce = 5.82f;
        bool gameOver = false;

        float myNumber = 5.0f;
        float b = 2.0f;
        float c = b * 2.0f; 
        
        myNumber += 15.2f;
        myNumber *= 3.0f;
        myNumber --;
        myNumber ++;
        myNumber += b;

        Debug.Log(myNumber);

        int numA = 20;
        int numB = 15;

        if(numA < numB)
        {
            Debug.Log("numA is less than numB");

            if(numA == 5 && numB == 6)
            {
                Debug.Log("NumA is % and numB is 6");
            }

            if(numA > 5 || numB >10)
            {
                Debug.Log("numA is greater than 5 and numB is greater than 10");
            }
        }
        else if(numA > numB)
        {
            Debug.Log("numA is greater than numB");
        }
        else
        {
            Debug.Log("numA is equal to numB");
        }

        Debug.Log(transform.position);

        Vector3 testVector = new Vector3(10,2,-5);

        transform.position += testVector; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
