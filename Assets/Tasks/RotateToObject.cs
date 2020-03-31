using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
public class RotateToObject : Action
{
    public GameObject Target;
    private float _angle;

    public override void OnStart()
    {
        Vector3 vectorToTarget = Target.transform.position - transform.position;
        _angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
    }

    public override TaskStatus OnUpdate()
    {
        transform.rotation = Quaternion.AngleAxis(_angle, Vector3.forward);
        return TaskStatus.Success;
    }
}
