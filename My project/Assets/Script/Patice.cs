using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patice : MonoBehaviour
{
    // 1. 속성 정의 (최대한 다양한 타입 활용)
    public string myName = "이준모";
    public int age = 21;
    public float height = 179.3f;
    public string mbti = "INTP-A";
    public bool military_service = true;
    public char bloodType = 'A';
    public double weight = 69.1;
    public long date_of_birth = 20000117;
    public string favoriteFood = "국밥";
    public bool canDrive = true;
    public string favoriteGame = "로스트아크";
    public string dreamJob = "QA";

    // 2. 함수 정의
    void PrintMyInfo()
    {
        Debug.Log(" - 나에 대한 정보 - ");
        Debug.Log("이름: " + myName);
        Debug.Log("나이: " + age + "살이 되고 싶은 27");
        Debug.Log("키: " + height + "cm");
        Debug.Log("MBTI: " + mbti);
        Debug.Log("군필 여부: " + military_service);
        Debug.Log("혈액형: " + bloodType);
        Debug.Log("몸무게: " + weight + "kg");
        Debug.Log("학번: " + date_of_birth);
        Debug.Log("좋아하는 음식: " + favoriteFood);
        Debug.Log("운전 가능 여부: " + canDrive);
        Debug.Log("최애 게임:" + favoriteGame);
        Debug.Log("희망 직군: " + dreamJob);
    }
    void Start()
    {
        PrintMyInfo();
    }
}
