using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 4f;
    [SerializeField] ITarget target;

    private int _deviation;
    private int _random_deviation;

    void Update()
    {
        Move(target);
    }
    void Move(ITarget target)
    {
        transform.Translate(movespeed * Time.deltaTime, 0, 0);
        _deviation++;
        _random_deviation = Random.Range(350, 100000);

        if (_deviation > _random_deviation)
        {
            movespeed = -movespeed;
            _deviation = 0;
        }
    }
}