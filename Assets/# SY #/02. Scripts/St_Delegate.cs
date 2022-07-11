using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_Delegate : MonoBehaviour
{
    // 참고 블로그 https://fiftiesstudy.tistory.com/225
    public delegate void Delegate1(int a, int b); // delegate 대리자 선언
    public Delegate1 delegate1; // 변수 선언

    // Start is called before the first frame update
    void Start()
    {
        delegate1 = Test1; // delegate 객체 생성부

        delegate1 += Test2; // 멀티캐스트 형태

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
