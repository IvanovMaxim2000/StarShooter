using UnityEngine;

public class SetMove : MonoBehaviour
{
    [SerializeField] public static bool isMoving;
    [SerializeField] GameObject[] gameobject;
    
    public void ActivateTarget()
    {
        isMoving = !isMoving;
        for (int i = 0; i < gameobject.Length; i++)
        {
            gameobject[i].GetComponent<Target>().enabled = !isMoving;
            gameobject[i].GetComponent<MovementDecorator>().enabled = isMoving;
        }
    }
}
