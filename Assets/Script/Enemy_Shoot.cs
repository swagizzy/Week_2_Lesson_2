using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    //The game object that will be spawned 
    public GameObject bullet;
    //Used to tell where the bullet will spawned 
    public Transform spawnPoint;
    //The trasnfom of the player 
    private Transform transformPlayer;

    //What the time resets to after we finish counting down to
    public float TIMER = 10f;
    //What the timer is at the moment 
    private float timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Finding the transform of the Player Game Object 
        transformPlayer = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the Enemy to look at the Player 
        transform.LookAt(transformPlayer);

        //Count down the time 
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //Create the bullet 
            var bulletVar = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            //Get Players rotation 
            var rotation = new Vector3(transform.eulerAngles.x, transform.transform.eulerAngles.y, 0);
            //Set the rotation to the bullet so it moves in that direction 
            bulletVar.GetComponent<Move_Arrow>().SetRoation(rotation);
            //Reset the timer 
            timeLeft = TIMER;
        }
    }
}
