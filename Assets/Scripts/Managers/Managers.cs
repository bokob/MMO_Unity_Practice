using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ� ����
    public static Managers Instance { get { Init(); return s_instance; } } // ������ �Ŵ����� ���� �´�.
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    // Update is called once per frame
    void Update()
    {

    }

    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go==null) // ������Ʈ�� ���ٸ�
            {
                go = new GameObject { name = "@Managers" }; // '@Managers' �� ����
                go.AddComponent<Managers>(); // Managers.cs �߰�
            }
            DontDestroyOnLoad(go); // �ı� �ȵǰ� �Ѵ�.
            s_instance = go.GetComponent<Managers>(); // ������ ������ ����
        }
    }

}
