using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonono : MonoBehaviour
    
{
    public float deathTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * 5;

    }
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(1) ;
        Destroy(gameObject);
    }
}
