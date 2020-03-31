using UnityEngine;
using BehaviorDesigner;
using BehaviorDesigner.Runtime.Tasks;

public class SeekToObject : Conditional
{
    public float Radius;
    public Transform SeekArea;
    public Transform Target;

    public override void OnAwake()
    {
        SeekArea.localScale = new Vector3(Radius, Radius, Radius);
    }

    public override TaskStatus OnUpdate()
    {
        if (Vector3.Distance(Target.position, transform.position) < Radius)
            return TaskStatus.Success;
        return TaskStatus.Failure;
    }
}
