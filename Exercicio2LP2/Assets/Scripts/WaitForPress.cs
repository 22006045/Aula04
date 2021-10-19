using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForPress : CustomYieldInstruction
{
    public override bool keepWaiting => !Input.anyKey;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
