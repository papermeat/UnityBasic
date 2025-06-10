using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class pratice250610 : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2

        int n = 5; // ������ ��� �� ���߿� �ڵ������ ����, �ٸ������ �ڵ� �б⵵ ������
        for (int i = 1; i <= n; i++)
        {
            int blankCount = n - i;
            int starCount = i;

            for (int j = 0; j < blankCount; j++) star += "��";
            for (int k = 0; k < starCount; k++) star += "��";
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            star += "\n";
        }
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 5 - i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;
        int n = 5;

        // ������ 4

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                star += "��";
            }
            for (int k = 1; k <= i; k++)
            {
                star += "��";
            }
            star += "\n";
        }
        for (int i = 1; i <= n - 1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "��";
            }
            for (int k = 1; k <= n - i; k++)
            {
                star += "��";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;
        int n = 5;
        // ������ 5

        // ����
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++) star += "��";         
            for (int k = 1; k <= 2 * i - 1; k++) star += "��";    
            star += "\n";
        }

        // �Ʒ���
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++) star += "��";
            for (int k = 1; k <= 2 * i - 1; k++) star += "��";
            star += "\n";
        }

        Debug.Log(star);
    }
}
