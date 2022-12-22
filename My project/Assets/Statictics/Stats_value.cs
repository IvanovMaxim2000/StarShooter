using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats_value : MonoBehaviour
{
    public int targetsHit;
    public int targetsMissed;

    [SerializeField] Slider accuracySlider;
    [SerializeField] TextMeshProUGUI targetsHitLabel, targetsMissedLabel, accuracyLabel;
    
    private void Update()
    {
        ShowStat();
    }
    void ShowStat()
    {
        if (targetsHit > 0 || targetsMissed > 0)
        {
            accuracySlider.value = targetsHit * 100 / (targetsHit + targetsMissed);
            accuracyLabel.text = $"Accuracy: {accuracySlider.value} %";
            targetsHitLabel.text = $"Targets hit: {targetsHit} ";
            targetsMissedLabel.text = $"Targets missed: {targetsMissed}";
        }
    }
}
