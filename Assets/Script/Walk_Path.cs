using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_Path : MonoBehaviour
{
    //List of the points the Enemy will travel towards
    public List<Transform> transforms = new List<Transform>();
    //Speed at which the enemy will move
    public float speed = 5; 
    //Current point the enemy is moving towards
    public int index = 0;

    // Update is called once per frame
    void Update()
    {
        //Tells it to move from currently standing in point, to given point at the given speed 
        transform.position = Vector3.MoveTowards(transform.position, transforms[index].position,
                    speed * Time.deltaTime);
        //Rotate to the direction 
        transform.rotation = transforms[index].rotation;
        //Checks if the enemy reached their goal 
        if (transform.position == transforms[index].position)
        {
            //If it's the last spot reset 
            if (index == transforms.Count - 1)
            {
                index = 0;
            }
            //else just go to next point in the list 
            else
            {
                index++;
            }
        }
    }
}
