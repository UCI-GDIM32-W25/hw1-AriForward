using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        seedsLeft -= 1;
        seedsPlanted += 1;
        _plantedText.SetText(" " + seedsPlanted);
        _remainingText.SetText(" " + seedsLeft);
    }
}