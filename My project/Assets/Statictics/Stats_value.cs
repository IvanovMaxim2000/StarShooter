using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats_value : MonoBehaviour
{
    public int targetsHit;
    public int targetsMissed;
    private int record;

    [SerializeField] Slider accuracySlider;
    [SerializeField] TextMeshProUGUI targetsHitLabel, targetsMissedLabel, accuracyLabel;
    [SerializeField] TextMeshProUGUI recordLabel;

    private void Start()
    {
        record = PlayerPrefs.GetInt("Best result");
    }
    private void OnEnable()
    {
        Timer.timePassed += SetRecord;
    }
   
    private void Update()
    {
        ShowStat();
    }
    private void ShowStat()
    {
        if (targetsHit > 0 || targetsMissed > 0)
        {
            accuracySlider.value = targetsHit * 100 / (targetsHit + targetsMissed);
            accuracyLabel.text = $"Accuracy: {accuracySlider.value} %";
            targetsHitLabel.text = $"Targets hit: {targetsHit} ";
            targetsMissedLabel.text = $"Targets missed: {targetsMissed}";
            recordLabel.text = $"Your record:{PlayerPrefs.GetInt("Best result")}";
        }
    }

    private void SetRecord()
    {
        if (record < targetsHit)
        {
            PlayerPrefs.SetInt("Best result", targetsHit);
        }
        Timer.timePassed -= SetRecord;
    }
}
