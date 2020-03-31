using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
public class SingleShoot : Action
{
    public Transform BulletTransform;
    public float ReloadSeconds;
    public float BulletSpeed;

    public override void OnStart()
    {
    }

    public override TaskStatus OnUpdate()
    {
        
        return TaskStatus.Running;
    }
}
