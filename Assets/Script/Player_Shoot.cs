using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{

    //The game object that will be spawned 
    public GameObject bullet;
    //Where the bullets will be placed after spawning 
    public GameObject bulletCollection;
    //Where the bullet will spawn at 
    public Transform spawnPoint;
    //The camera 
    private Camera _camera;


    // Start is called before the first frame update
    void Start()
    {
        _camera = transform.Find("Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the player clicks any of the buttons accositaed with the Fire1 
        if (Input.GetButtonDown("Fire1"))
        {
            //Create the bullet 
            var bulletVar = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            //Get the angle for the bullet 
            var rotation = new Vector3(transform.eulerAngles.x, _camera.transform.eulerAngles.y, 0);
            //Sets the rotation for the bullet 
            bulletVar.GetComponent<Move_Arrow>().SetRoation(rotation);
            //Put the bullet in the collection folder 
            bulletVar.transform.SetParent(bulletCollection.transform);
        }
    }
}
