using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutine : MonoBehaviour
{
    Coroutine hello;
    // Start is called before the first frame update
    void Start()
    {
        hello = StartCoroutine(Wait4in4Seconds());
        StartCoroutine(PrintValuesEverySec());
        StartCoroutine(BeingPressed());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Wait4in4Seconds() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(4);
            print("Hello");
        }
    }

    private IEnumerator PrintValuesEverySec() 
    {
        int num = 0;
        while (true)
        {
            
            print(num);
            if(num > 30) 
            {
                StopCoroutine(hello);
            }
            num++;
            yield return new WaitForSeconds(1);
        }
    }

    private IEnumerator BeingPressed() 
    {
        while (true)
        {
            
            yield return new WaitForAnyKey();
            print("I'm being pressed");
        }
        
        
    }
}
