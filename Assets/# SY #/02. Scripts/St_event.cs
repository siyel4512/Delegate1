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

// ���� ��α� https://fiftiesstudy.tistory.com/226?category=902900
public delegate void eventHandler_Test();

// �̺�Ʈ �Խ��� (�߻�)
public class EventGiver
{
    public static event eventHandler_Test testEvent; // �̺�Ʈ ����

    // �̺�Ʈ�� �����Ҷ� ����� �޼���
    public void RunEvent()
    {
        if (testEvent != null)
        {
            testEvent();
        }
    }
}

// �̺�Ʈ ��� (����)
public class EventCatchers
{
    // ������
    public EventCatchers()
    {
        EventGiver.testEvent += EventHandler;
    }

    public void EventHandler()
    {
        Debug.Log("�̺�Ʈ �߻�");
    }
}
