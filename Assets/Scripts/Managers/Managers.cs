using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성 보장
    static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고 온다.
    
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
            if(go==null) // 오브젝트가 없다면
            {
                go = new GameObject { name = "@Managers" }; // '@Managers' 로 생성
                go.AddComponent<Managers>(); // Managers.cs 추가
            }
            DontDestroyOnLoad(go); // 파괴 안되게 한다.
            s_instance = go.GetComponent<Managers>(); // 유일한 것으로 지정
        }
    }

}
