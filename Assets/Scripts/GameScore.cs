using UnityEngine;
using UnityEngine.Events;

public class GameScore : MonoBehaviour
{
    public UnityEvent ScoreChanged;

    private int _score;
    public int Score => _score;

    private void Awake()
    {
        _score = 0;
    }

    public void IncreaseScore()
    {
        _score += 1;
        ScoreChanged?.Invoke();
    }

    public void SaveBestScore()
    {
        if(_score > LoadPlayerData.LoadBestScore())
        {
            SavePlayerData.SaveBestScore(_score);
        }
    }
}
