using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    string[] character = { "정은교", " 김한나", "손석현", "이윤호", "엄지성", "신채현", "차정훈", "최현석" };
    List<string> characterList = new List<string>();
    void Start()
    {
        characterList.Add("정은교");
        characterList.Add("김한나");
        characterList.Add("손석현");
        characterList.Add("이윤호");
        characterList.Add("엄지성");
        characterList.Add("신채현");
        characterList.Add("차정훈");
        characterList.Add("최현석");
    }

    public void ArrayGacha()
    {
        int randomValue = Random.Range(0, character.Length); // 8, 0 ~ 7

        Debug.Log($"범인은?" + character[randomValue] + "였습니다.");
    }
    public void ListGacha()
    {
        int randomValue = Random.Range(0, characterList.Count); // 8, 0 ~ 7
        Debug.Log($"범인은?" + characterList[randomValue] + "였습니다.");
    }

    public void AddList()
    {
        // character 배열에는 사람 이름이 있습니다
        // characterList에는 아무 데이터도 없습니다.

        // character 배열이ㅡ 데이터를 characterList에다가 넣어주는 식을 만들어봅시다.
        // 우리가 배운 반복문을 사용해서 만들어 봅시다.

        for (int i = 0; i < character.Length; i++) // 1 , 8 → 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}