using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Arrow : MonoBehaviour
{
    //Connect Ridigbody to move forward 
    private Rigidbody _rigidbody;
    //How long we should wait to destory the bullet 
    public float endTime = 5; 

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //Start the Courtuine and wait to destory the bullet 
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        //Move the game object forward 
        _rigidbody.velocity = transform.forward;
    }

    //Get the rotation of the shooter and set it to the bullet so that it uses that as the forward velocity 
    public void SetRoation(Vector3 roation)
    {
        transform.eulerAngles = roation;
    }

    //Waits for the timer to end and then Destorys the bullet 
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(endTime);
        Destroy(gameObject);
    }

}
