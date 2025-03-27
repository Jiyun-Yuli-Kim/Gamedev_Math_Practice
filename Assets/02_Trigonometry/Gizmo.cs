using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    public float axisLength = 5f;

    void OnDrawGizmos()
    {
        // X축 (빨강)
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * axisLength);

        // Y축 (초록)
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * axisLength);

        // Z축 (파랑, 2D면 생략 가능)
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.forward * axisLength);
    }
}
