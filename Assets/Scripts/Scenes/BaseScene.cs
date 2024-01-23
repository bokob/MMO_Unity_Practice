using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseScene : MonoBehaviour
{
    public Define.Scene SceneType { get; protected set; } = Define.Scene.Unknown;
    void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        // 이벤트 시스템이 있는지 찾는다.
        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));
        if (obj == null) // 없으면 생성
            Managers.Resource.Instantiate("UI/EventSystem").name = "@EventSystem";
    }

    public abstract void Clear();
}
