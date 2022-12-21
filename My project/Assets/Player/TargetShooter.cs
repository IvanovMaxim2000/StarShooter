using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] Stats_value stats;

    void Start()
    {
        TargetBounds.Instance.GetRandomPosition();
    }
    void Update()
    {
        if (!PauseMenu.gamePaused)
        {
            if (Stamina.canShooting) Shooting();
        }
    }
    void Shooting()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(camera.transform.position, camera.transform.forward, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                    Target target = hit.collider.gameObject.GetComponent<Target>();
                    Debug.Log(target.GetType());
                    if (target != null) Hit(target);
            }
            else Miss();
        }
    }
    void Hit(ITarget target)
    {
        stats.targetsHit++;
        target.NewPosition();
        Stamina.instance.AddStamina(target);
    }

    void Miss()
    {
        stats.targetsMissed++;
        Stamina.instance.UseStamina(1);
    }
}
