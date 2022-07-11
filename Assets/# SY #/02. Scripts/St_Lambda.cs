using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class St_Lambda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        action1(1);
        action2(2);
        action3(3);

        Debug.Log("func1 : " + func1(10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Action<int> action1 = (int a) => Debug.Log("action1 : " + a);

    Action<int> action2 = (int a) =>
    {
        Debug.Log("action2 : " + a);
    };

    Action<int> action3 = a =>
    {
        Debug.Log("action3 : " + a);
    };

    //Action action3 => Debug.Log("action3 : ");

    Func<int, int> func1 = x => x;
}
