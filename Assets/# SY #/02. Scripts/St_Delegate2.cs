using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_Delegate2 : MonoBehaviour
{
    // �ݹ��Լ���, ������ ó���� ���� �Ŀ�, ȣ���ϰ� ���� ó���� �ǹ��ϴ°�����, �񵿱� ó���� ���� ���� � ���Ǵ� ��찡 ����.
    // ���� ��α� https://engineer-mole.tistory.com/176

    // delegate ����
    public delegate void Callback();
    private Callback sayHowAreYou;

    // Start is called before the first frame update
    void Start()
    {
        sayHowAreYou = SayHowAreYou; // �Լ� ����

        SaySomethingAfterHello(sayHowAreYou);
    }

    private void SayHowAreYou()
    {
        print("How are you?");
    }

    private void SaySomethingAfterHello(Callback _callback)
    {
        print("Hello World!!!");
        _callback(); // delegate ����, ������ �Լ��� �����
    }
}
