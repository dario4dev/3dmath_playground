using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger: MonoBehaviour
{
    public Vector3 targetPoint;
    public float lookAtThreshold = 0.03f;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Vector3 toTargetDir = (targetPoint - transform.position).normalized;
        Gizmos.DrawRay(transform.position, toTargetDir);
        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, transform.right);

        float lookness = Vector3.Dot(toTargetDir, transform.right);
        Gizmos.color = lookness > 1.0f  - lookAtThreshold ? Color.green : Color.yellow;
        Gizmos.DrawSphere(targetPoint, 0.1f);
    }

}
