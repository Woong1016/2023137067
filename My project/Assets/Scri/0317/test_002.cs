using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;   //���� answer ����
        answer = 1 + 2;  // answer�� 1+2 ���� ���� �Է�
        Debug.Log(answer); // answer �� debug.Log�� ��½�Ų��.

        int n1 = 8;     //���� n1 ���� �� �� 8�� �Է�
        int n2 = 9;     //���� n2 ���� �� �� 9�� �Է�
        int answer2;    //���� answer2 ����
        answer2 = n1 + n2;  //���� answer2�� n1�� n2 ���Ѱ��� �Է�  
        Debug.Log(answer2); //answer2�� debug.Log�� ��½�Ų��.

        int answer3 = 10;   // ���� answer3 ���� �� �� 10���Է�
        answer3 += 5;       //���� answer3�� +5���� �߰� (answer3 =answer3+5)
        Debug.Log(answer3); //answer3�� Debug.Log�� ��� ��Ų��.
        answer3++;          //���� answer3�� +1 ���� �߰� (answer3 = answer3+1)    
        Debug.Log(answer3); // answer3�� Debug.Log�� ��½�Ų��

        string str = "Happy";   // ���ڿ� str�� "Happy" �Է�
        string str2 = "birthday";  //���ڿ� str2�� "birthday" �Է�  

        str += str2;        //str=str +str2;
        Debug.Log(str);     // str �� �� ���� debug.log�� ��½�Ų��.

        string message = str + answer3;    //���ڿ� message�� �����ϰ� (string)�� str�� (int)�� answer3�� ���Ѵ�.
        Debug.Log(message);                //message ���� Debug.Log�� ��½�Ų��.
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}