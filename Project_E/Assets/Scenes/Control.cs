using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;
    public int[] array2 = new int[3];
    public char[,] ch2 = new char[3, 3];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {/*
        if (a > b)
        {
            Debug.Log("a 가 b보다 큽니다");
        }
        else if (a < b)
        {
            Debug.Log("a 가 b보다 크지 않습니다");
        }
        else
        {
            Debug.Log("a 와 b 는 같습니다");
        }

        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다");
                break;
            case "바나나":
                Debug.Log("바나나는 노랗습니다");
                break;
            case "포도":
                Debug.Log("포도는 보라색입니다");
                break;
            default:
                Debug.Log("알 수 없는 과일입니다");
                break;
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("for 문 실행 중: " + i);
        }

        while (a < 10)
        {
            Debug.Log("a의 값: " + a);
            a++;
        }
        do
        {
            Debug.Log("b의 값: " + b);
            b--;
        } while (b > 0);
        */
        string[] array = new string[5];
        array[0] = "강대원";
        array[1] = "민영희";
        array[2] = "박두팔";
        array[3] = "안선생";
        array[4] = "함수빈";

        array = new string[6];

        for (int i = 0; i < array.Length; i++)
        {
            //Debug.Log(i);
            //Debug.Log(array[i]);
        }

        int[] scores = { 90, 85, 78, 92, 88 };
        
        for (int j = 0; j<array2.Length; j++)
        {         
            //Debug.Log("배열의 값" + j + ":"+ array2[j]);
        }

        string[,] zoo = new string[3, 3];
        zoo[0, 0] = "사자";
        zoo[0, 1] = "호랑이";
        zoo[0, 2] = "표범";
        zoo[1, 0] = "코끼리";
        zoo[1, 1] = "기린";
        zoo[1, 2] = "하마";
        zoo[2, 0] = "원숭이";
        zoo[2, 1] = "침팬지";
        zoo[2, 2] = "고릴라";

        int[,] samsam = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 },{ 10,11,12} };

        List<string> studentList = new List<string>();

        studentList.Add("강대원");
        studentList.Add("민영희");
        studentList.Add("박두팔");
        studentList.Add("안선생");
        studentList.Add("함수빈");
        studentList.Add("구경일");

        studentList.Remove("박두팔");
        //studentList.RemoveAt(2);

        Debug.Log(studentList[3]);


    }

}

// Update is called once per frame



