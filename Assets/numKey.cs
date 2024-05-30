using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numKey : MonoBehaviour
{
    public TMP_InputField NumInputField;
    public GameObject Num1;
    public GameObject Num2;
    public GameObject Num3;
    public GameObject Num4;
    public GameObject Num5;
    public GameObject Num6;
    public GameObject Num7;
    public GameObject Num8;
    public GameObject Num9;
    public GameObject Num0;
    public GameObject clearButton;


    public void n1()
    {
        NumInputField.text = NumInputField.text + "1";
    }
    public void n2()
    {
        NumInputField.text = NumInputField.text + "2";
    }
    public void n3()
    {
        NumInputField.text = NumInputField.text + "3";
    }
    public void n4()
    {
        NumInputField.text = NumInputField.text + "4";
    }
    public void n5()
    {
        NumInputField.text = NumInputField.text + "5";
    }
    public void n6()
    {
        NumInputField.text = NumInputField.text + "6";
    }
    public void n7()
    {
        NumInputField.text = NumInputField.text + "7";
    }
    public void n8()
    {
        NumInputField.text = NumInputField.text + "8";
    }
    public void n9()
    {
        NumInputField.text = NumInputField.text + "9";
    }
    public void n0()
    {
        NumInputField.text = NumInputField.text + "0";
    }
    public void clear()
    {
        NumInputField.text = null;
    }

}
