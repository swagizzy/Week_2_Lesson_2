using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform trans = transform.GetChild(0).GetComponent<Transform>();
        trans.position = GameObject.Find("MovePoint").GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
