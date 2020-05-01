using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{

    float speed = 10;
    
    void Update()
    {
        float horizontalMovements = Input.GetAxis("Horizontal");
        float verticalMovements = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, 0, 0);   //new vector for movements traslation

        //check Horizontal
        if (horizontalMovements != 0)
        {
            direction.x = horizontalMovements;
        }

        //check Vertical
        if (verticalMovements != 0)
        {
            direction.y = verticalMovements;
        }

        transform.Translate(direction * (speed * Time.deltaTime));    //move object
    }
}
