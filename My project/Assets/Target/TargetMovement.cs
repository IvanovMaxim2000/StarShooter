using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 4f;
    [SerializeField] ITarget target;

    private int _deviation;
    private int _randomDeviation;

    void Update()
    {
        Move(target);
    }
    void Move(ITarget target)
    {
        transform.Translate(movespeed * Time.deltaTime, 0, 0);
        _deviation++;
        _randomDeviation = Random.Range(350, 100000);

        if (_deviation > _randomDeviation)
        {
            movespeed = -movespeed;
            _deviation = 0;
        }
    }
}