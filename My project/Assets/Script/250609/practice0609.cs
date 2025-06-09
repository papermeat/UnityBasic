using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice0609 : MonoBehaviour
{
    List<string> characterList = new List<string>
    {
        "반디", "카스토리스", "세이버", "트리비", "로빈",  // 5성
        "페라", "아스타", "갤러거", "미샤", "헤르타"       // 4성
    };

    // 5성 목록
    List<string> fiveStarList = new List<string>
    {
        "반디", "카스토리스", "세이버", "트리비", "로빈"
    };

    // 4성 목록
    List<string> fourStarList = new List<string>
    {
        "페라", "아스타", "갤러거", "미샤", "헤르타"
    };

    public void Gacha10()
    {
        Debug.Log("10연차 뽑기 시작");

        int fiveStarCount = 0;
        int fourStarCount = 0;

        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 1 ~ 100
            string pickedCharacter = "";

            if (randomValue <= 10) // 10% 확률로 5성
            {
                int index = Random.Range(0, fiveStarList.Count);
                pickedCharacter = fiveStarList[index];
                fiveStarCount++;
                Debug.Log($"[{i + 1}번째] 5성 획득! → {pickedCharacter}");
            }
            else // 90% 확률로 4성
            {
                int index = Random.Range(0, fourStarList.Count);
                pickedCharacter = fourStarList[index];
                fourStarCount++;
                Debug.Log($"[{i + 1}번째] 4성 획득 → {pickedCharacter}");
            }
        }

        Debug.Log($"총 결과: 5성 {fiveStarCount}개, 4성 {fourStarCount}개");
    }
}