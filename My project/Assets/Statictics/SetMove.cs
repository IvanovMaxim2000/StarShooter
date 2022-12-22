using UnityEngine;

public class SetMove : MonoBehaviour
{
    [SerializeField] public static bool isMoving;
    [SerializeField] GameObject[] gameObject;
    
    public void ActivateTarget()
    {
        isMoving = !isMoving;
        for (int i = 0; i < gameObject.Length; i++)
        {
            gameObject[i].GetComponent<Target>().enabled = !isMoving;
            gameObject[i].GetComponent<MovementDecorator>().enabled = isMoving;
        }
    }
}
