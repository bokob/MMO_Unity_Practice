using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) �� Ȥ�� ������� Rigidbody�� �־�� �Ѵ�. (Is Kinematic : Off)
    // 2) ������ Collider�� �־�� �Ѵ�. ( Is Trigger : Off)
    // 3) �������  Collider�� �־�� �Ѵ� (Is Trigger : Off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name} !");
    }
    // 1) �� �� Collider�� �־�� �Ѵ�.
    // 2) �� �� �ϳ��� Is Trigger : On
    // 3) �� �� �ϳ��� RigidBody�� �־�� �Ѵ�.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger @ {other.gameObject.name} !");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
