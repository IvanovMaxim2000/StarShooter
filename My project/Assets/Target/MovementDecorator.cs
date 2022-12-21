using UnityEngine;

public abstract class TargetDecorator : Target
{
    protected ITarget target;
    protected void SetTarget(ITarget target) => this.target = target;
}

public class MovementDecorator : TargetDecorator
{
    public override int ExtraStamina => 3;
    private float _movespeed = 4f;
    private int _deviation;
    private int _randomDeviation;

    private void Update()
    {
        Move();
    }

    private void Start()
    {
        SetTarget(target);
    }
    public void Move()
    {
        transform.Translate(_movespeed * Time.deltaTime, 0, 0);
        _deviation++;
        _randomDeviation = Random.Range(350, 100000);

        if (_deviation > _randomDeviation)
        {
            _movespeed = -_movespeed;
            _deviation = 0;
        }
    }
}
