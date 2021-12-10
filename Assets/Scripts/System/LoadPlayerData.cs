using UnityEngine;

public class LoadPlayerData
{
    public static int LoadBestScore()
    {
        return PlayerPrefs.GetInt("BestScore", 0);
    }

    public static int LoadUsedPlayerBird()
    {
        //Id is a index in BirdContainer   
        return PlayerPrefs.GetInt("ActivePlayerBirdId", 0);
    }
}
