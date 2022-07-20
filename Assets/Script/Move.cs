using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Variables 
    public float speed = 5;         //How fast the player moves 
    public float xRotation = 2f;    //How fast we rotate around x
    public float yRotation = 1f;    //How fast we roate aroudn y

    //Components 
    private CharacterController characterController;
    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        _camera = transform.Find("Camera").GetComponent<Camera>();

        // Lock cursor to the screen and make it invisible
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Roates the camera around Y axis letting you look left and right 
        transform.Rotate(0, xRotation * Input.GetAxis("Mouse X"), 0);

        //Takes in the input to move forward, backward, left and right 
        Vector3 movement = new Vector3(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical"));
        //transform.TransformDirection localized the movment to the roation of the player 
        characterController.Move(transform.TransformDirection(movement * Time.deltaTime));

        //Rotates the camera around the x axis to allow the player to look up and down
        _camera.transform.Rotate( yRotation * -Input.GetAxis("Mouse Y"), 0, 0);
        //If we're looking in negative angle 
        if(_camera.transform.eulerAngles.x >= 50)
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x - 360, -30, 0), _camera.transform.eulerAngles.y, 0);
        }
        //If we're looking in postive angle 
        else
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x, 0, 30f), _camera.transform.eulerAngles.y, 0);
        }
    }
}