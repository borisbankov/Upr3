using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    // Start is called before the first frame update
    float degrees = 90.0f;
    void Start()
    {
        StartCoroutine(Rotate());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Rotate()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if(transform.position.y > -9.0f)
            transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + 90.0f));
        }
    }

}
