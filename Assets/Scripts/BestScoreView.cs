using UnityEngine;
using UnityEngine.UI;

public class BestScoreView : MonoBehaviour
{
    private Text _bestScoreText;

    private void Awake()
    {
        _bestScoreText = GetComponent<Text>();
        _bestScoreText.text = "Best score: " + LoadPlayerData.LoadBestScore().ToString();
    }


}
