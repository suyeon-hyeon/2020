using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World");  // Hello, World를 Console창에 출력한다.

        int age;
        age = 30;
        Debug.Log(age);  // 30

        float height1 = 160.5f;  // float형에 소수를 대입할 때는 반드시 값 뒤에 f를 붙여야 한다.
        float height2;
        height2 = height1;
        Debug.Log(height2);  // 160.5

        string name;
        name = "Sera";
        Debug.Log(name);  // Sera

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);  // 3

        answer = 3 - 4;
        Debug.Log(answer);  // -1

        answer = 5 * 6;
        Debug.Log(answer);  // 30

        answer = 8 / 4;
        Debug.Log(answer);  // 2

        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);  // 17

        answer = 10;
        answer += 10;
        Debug.Log(answer);  // 20

        answer = 10;
        answer++;
        Debug.Log(answer);  // 11

        string str1 = "happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);  // happy birthday

        str1 += str2;
        Debug.Log(str1);  // happy birthday

        string str = "happy ";
        int num = 123;

        message = str + num;  // num 변수를 문자열로 취급한 후 덧셈을 실행한다.
        Debug.Log(message);  // happy 123
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
