using UnityEngine;
using System;

public interface ITarget
{
    int ExtraStamina { get; }
    void NewPosition();
}

public class Target : MonoBehaviour, ITarget
{
    public virtual int ExtraStamina => 1;
    public static Action onDestroyed;

    public void NewPosition()
    {
        transform.position = TargetBounds.Instance.GetRandomPosition();
        onDestroyed?.Invoke();
    }
}

public class Target2 : MonoBehaviour, ITarget
{
    public int ExtraStamina => 3;
    public static Action onDestroyed;

    public void NewPosition()
    {
        transform.position = TargetBounds.Instance.GetRandomPosition();
        onDestroyed?.Invoke();
    }
}
