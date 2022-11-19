using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForAnyKey : CustomYieldInstruction
{
    public override bool keepWaiting => !Input.anyKey ;

    
}
