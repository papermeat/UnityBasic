using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �ּ��� �̰�
/* �� �� �ּ���
�̰� */

public class Test : MonoBehaviour
{
        void OnEnable()
        {
        Random.InitState(7); // ������ �õ尪�� ����
            Debug.Log(Random.Range(1, 100));
            // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
        }
        // Debug.Log("�ȳ��ϼ���");
        // Debug.Log("���ñ��� ȭ�����ϸ� ���� �� �� �־��!");
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

    void MonsterSpawn() // ����
    {
        B.SetLevel(A.Level());
    }
}
*/