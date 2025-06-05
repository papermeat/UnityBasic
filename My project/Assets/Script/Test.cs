using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 주석은 이거
/* 긴 글 주석은
이거 */

public class Test : MonoBehaviour
{
        void OnEnable()
        {
        Random.InitState(7); // 랜덤한 시드값을 고정
            Debug.Log(Random.Range(1, 100));
            // 1 이상 100 미만의 랜덤한 값을 만들겠다.
        }
        // Debug.Log("안녕하세요");
        // Debug.Log("오늘까지 화이팅하면 내일 쉴 수 있어요!");
    }




/*
public class Player
{
    private int playerLevel = 10;

    public int Level()
    {
        return playerLevel;
    }
}

public class Monster
{
    private int monsterLevel;

    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

public class Game
{
    Player A;
    Monster B;

    void MonsterSpawn() // 몬스터
    {
        B.SetLevel(A.Level());
    }
}
*/