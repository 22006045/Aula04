using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCO : MonoBehaviour
{   
    [SerializeField]
    private float seconds = 4;
    [SerializeField]
    private float secondsUp = 1;
    [SerializeField]
    private float secsStopHello = 30;

    [SerializeField]
    private Coroutine printHello;



    private IEnumerator PrintHello(float secs)
    {
        WaitForSeconds wts = new WaitForSeconds(secs);
        while(true)
        {
            Debug.Log("Hello");
            yield return wts;
        }
    }
    private IEnumerator CountUp(float secs, float secsStopHello)
    {
        int count = 0;
        WaitForSeconds wts = new WaitForSeconds(secs);
        while(true)
        {   
            count++;
            Debug.Log($"{count}");
            if(count == secsStopHello)
            {
                StopCoroutine(printHello);
            }
            yield return wts;
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        printHello = StartCoroutine(PrintHello(seconds));
        StartCoroutine(CountUp(secondsUp,secsStopHello));
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
