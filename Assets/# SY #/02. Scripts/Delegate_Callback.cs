using System.Collections;
using System.Collections.Generic;
using UnityEngine;

delegate void Delegate_1();

public class Delegate_Callback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TEST1 test1 = new TEST1();
        TEST2 test2 = new TEST2();

        test1.Function1(test2);
    }
}

class TEST1
{
    public void Function1(TEST2 test2)
    {
        Delegate_1 delegate_1 = Function2;

        test2.Function3(delegate_1);
    }

    public void Function2()
    {
        Debug.Log("Function2()!!!!!!!");
    }
}

class TEST2
{
    public void Function3(Delegate_1 delegate_1)
    {
        Debug.Log("Function3()!!!!!!!");

        delegate_1();
    }
}