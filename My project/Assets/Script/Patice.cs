using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patice : MonoBehaviour
{
    // 1. �Ӽ� ���� (�ִ��� �پ��� Ÿ�� Ȱ��)
    public string myName = "���ظ�";
    public int age = 21;
    public float height = 179.3f;
    public string mbti = "INTP-A";
    public bool military_service = true;
    public char bloodType = 'A';
    public double weight = 69.1;
    public long date_of_birth = 20000117;
    public string favoriteFood = "����";
    public bool canDrive = true;
    public string favoriteGame = "�ν�Ʈ��ũ";
    public string dreamJob = "QA";

    // 2. �Լ� ����
    void PrintMyInfo()
    {
        Debug.Log(" - ���� ���� ���� - ");
        Debug.Log("�̸�: " + myName);
        Debug.Log("����: " + age + "���� �ǰ� ���� 27");
        Debug.Log("Ű: " + height + "cm");
        Debug.Log("MBTI: " + mbti);
        Debug.Log("���� ����: " + military_service);
        Debug.Log("������: " + bloodType);
        Debug.Log("������: " + weight + "kg");
        Debug.Log("�й�: " + date_of_birth);
        Debug.Log("�����ϴ� ����: " + favoriteFood);
        Debug.Log("���� ���� ����: " + canDrive);
        Debug.Log("�־� ����:" + favoriteGame);
        Debug.Log("��� ����: " + dreamJob);
    }
    void Start()
    {
        PrintMyInfo();
    }
}
