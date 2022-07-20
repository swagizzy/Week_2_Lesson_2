using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        //Connect to the Character Contorller game component 
        characterController = GetComponent<CharacterController>();  
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check if the collider that touched it is tagged with Bullet 
        if (other.CompareTag("Bullet"))
        {
            //If so move the game object back 
            characterController.Move(-transform.forward);
            //Destory the Bullet 
            Destroy(other.gameObject);
        }
    }
}
