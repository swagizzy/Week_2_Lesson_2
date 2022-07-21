using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okokok : MonoBehaviour
    
{
    public GameObject _bullet;
    public Transform _spawnPoint;
    public Transform trash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bulletVar = Instantiate(_bullet, _spawnPoint.position, Quaternion.identity);
            bulletVar.transform.SetParent(trash);
        }
    }
}
