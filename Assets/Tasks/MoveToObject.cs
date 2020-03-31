using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
public class MoveToObject : Action
{
    public GameObject Target;
    public float Speed;

    public override TaskStatus OnUpdate()
    {
        if(Vector3.SqrMagnitude(transform.position - Target.transform.position) < 0.1f)
        {
            return TaskStatus.Success;
        }
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Speed * Time.deltaTime);
        return TaskStatus.Running;
    }
}
