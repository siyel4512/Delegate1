using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_Delegate : MonoBehaviour
{
    public delegate void Delegate1(int a, int b);
    public Delegate1 delegate1;

    // Start is called before the first frame update
    void Start()
    {
        delegate1 = Test1;
        delegate1 += Test2;

        delegate1(5, 2);
    }

    public void Test1(int a, int b)
    {
        print("Test1 함수 호출 : " + (a + b));
    }

    public void Test2(int a, int b)
    {
        print("Test2 함수 호출 : " + (a - b));
    }
}
