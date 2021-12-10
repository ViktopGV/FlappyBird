using UnityEngine;

public static class SavePlayerData
{
    public static void SaveBestScore(int bestScoreValue)
    {
        PlayerPrefs.SetInt("BestScore", bestScoreValue);
    }

    /// <summary>
    /// The method get an index of bird in BirdContainer
    /// </summary>
    /// <param name="index"></param>
    public static void SaveUsedPlayerBird(int index)
    {
        PlayerPrefs.SetInt("ActivePlayerBirdId", index);
    }


}

