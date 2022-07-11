using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_event : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCatchers eventCatcher = new EventCatchers();
        EventGiver eventGiver = new EventGiver();

        eventGiver.RunEvent();
    }
}

// 참고 블로그 https://fiftiesstudy.tistory.com/226?category=902900
public delegate void eventHandler_Test();

// 이벤트 게시자 (발생)
public class EventGiver
{
    public static event eventHandler_Test testEvent; // 이벤트 선언

    // 이벤트를 실행할때 사용할 메서드
    public void RunEvent()
    {
        if (testEvent != null)
        {
            testEvent();
        }
    }
}

// 이벤트 잡기 (반응)
public class EventCatchers
{
    // 생성자
    public EventCatchers()
    {
        EventGiver.testEvent += EventHandler;
    }

    public void EventHandler()
    {
        Debug.Log("이벤트 발생");
    }
}
