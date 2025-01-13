using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    int seedsPlanted = -1;
    public void UpdateSeeds (int _numSeeds)
    {
        seedsPlanted += 1;
        _remainingText.SetText("" + _numSeeds);
        _plantedText.SetText("" + seedsPlanted);
        
    }
}