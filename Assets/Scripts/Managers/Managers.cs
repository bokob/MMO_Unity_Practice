using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ� ����
    static Managers Instance { get { Init(); return s_instance; } } // ������ �Ŵ����� ���� �´�.
    
    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }

    void Start()
    {
        Init();
    }
    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
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
