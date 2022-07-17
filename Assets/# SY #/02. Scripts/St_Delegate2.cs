using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_Delegate2 : MonoBehaviour
{
    // 콜백함수란, 무언가의 처리가 끝난 후에, 호출하고 싶은 처리를 의미하는것으로, 비동기 처리의 종료 통지 등에 사용되는 경우가 많다.
    // 참고 블로그 https://engineer-mole.tistory.com/176

    // delegate 선언
    public delegate void Callback();
    private Callback sayHowAreYou;

    // Start is called before the first frame update
    void Start()
    {
        sayHowAreYou = SayHowAreYou; // 함수 대입

        SaySomethingAfterHello(sayHowAreYou);
    }

    private void SayHowAreYou()
    {
        print("How are you?");
    }

    private void SaySomethingAfterHello(Callback _callback)
    {
        print("Hello World!!!");
        _callback(); // delegate 실행, 대입한 함수가 실행됨
    }
}
