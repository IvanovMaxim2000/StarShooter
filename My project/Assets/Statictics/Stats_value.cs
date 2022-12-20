using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats_value : MonoBehaviour
{
    public int targetsHit;
    public int targetsMissed;

    [SerializeField] Slider accuracy_slider;
    [SerializeField] TextMeshProUGUI targetshitLabel, targetsmissedLabel, accuracyLabel;
    
    private void Update()
    {
        ShowStat();
    }
    void ShowStat()
    {
        if (targetsHit > 0 || targetsMissed > 0)
        {
            accuracy_slider.value = targetsHit * 100 / (targetsHit + targetsMissed);
            accuracyLabel.text = $"Accuracy: {accuracy_slider.value} %";
            targetshitLabel.text = $"Targets hit: {targetsHit} ";
            targetsmissedLabel.text = $"Targets missed: {targetsMissed}";
        }
    }
}
