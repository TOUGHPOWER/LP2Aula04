using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait4in4Seconds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Wait4in4Seconds() 
    {
        while (true) 
        {
            print("Hello");

            yield return new WaitForSeconds(4);
        }
    }
}
