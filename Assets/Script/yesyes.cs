using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesyes : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider _collider;
    private Transform _transform;
    private Camera _camera;
    private Transform _otherPlace;
    public float x = 1;
    public float z = 1;
    private CharacterController _characterController;
    void Start()
    {
        //_collider = GetComponent<BoxCollider>();
        _transform = GetComponent<Transform>();
        //print(_collider.name);
        _camera = transform.Find("Camera").GetComponent<Camera>();
        _camera = transform.GetChild(0).GetComponent<Camera>();

        //_otherPlace = GameObject.Find("Cube").GetComponent<Transform>();

        _characterController = GetComponent<CharacterController>();
        _camera = transform.GetChild(0).GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime;
        Vector3 move = new Vector3(-x * Input.GetAxis("Horizontal" ) * time, 0, -z * Input.GetAxis("Vertical") * time);
        _characterController.Move(_transform.TransformDirection(move));

        _transform.Rotate(0, 1 * Input.GetAxis("Mouse X"), 0);

        _camera.transform.Rotate(-1 * Input.GetAxis("Mouse Y"), 0, 0);
        print(_camera.transform.eulerAngles);
        if(_camera.transform.eulerAngles.x >= 50)
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x -360, -30, 0), _camera.transform.eulerAngles.y, 0);
        }
        else
        {
            _camera.transform.eulerAngles = new Vector3(Mathf.Clamp(_camera.transform.eulerAngles.x, 0, 30f), _camera.transform.eulerAngles.y, 0);
        }
    }
}

