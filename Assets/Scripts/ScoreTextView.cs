using UnityEngine;
using UnityEngine.UI;

public class ScoreTextView : MonoBehaviour
{
    [SerializeField] private GameScore _score;
    private Text _scoreText;

    [SerializeField] private bool _additionalText; 
    

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
        UpdateScoreTextView();
    }

    public void UpdateScoreTextView()
    {
        //этот костыль сделан чтобы не делать два компонента для текущего счета
        //этот компонент используется как показатель игрового счета как во время игры, так и в панели GameOver
        if(_additionalText)
        {
            _scoreText.text = "Current score: " + _score.Score.ToString();
        }
        else
        {
            _scoreText.text = _score.Score.ToString();
        }
    }
}
