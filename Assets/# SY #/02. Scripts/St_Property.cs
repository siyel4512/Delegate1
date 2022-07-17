using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class St_Property : MonoBehaviour
{
    private int num = 2;

    public int Num => num;

    public int Num2 { get => num; set { num *= value; Debug.Log(num); } }
    public int Num3 { get { return num; } set { num *= value; Debug.Log(num); } }

    public int Result(int _inputValue)
    {
        return _inputValue;
    }

    // Start is called before the first frame update
    void Start()
    {
        Num2 = 2;
        Debug.Log("result1 : " + Result(Num2));
        
        Num3 = 4;

        Debug.Log("result2 : " + Result(Num3));
    }
}
