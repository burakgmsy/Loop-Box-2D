using UnityEngine;

public class PlayerPrefsManager : Singleton<PlayerPrefsManager>
{
    private const string HIGHSCORE_PREFS = "Highscore";

    public void SaveHighscore(int highscore)
    {
        int score = GetHighscore();
        if (highscore > score)
        {
            PlayerPrefs.SetInt(HIGHSCORE_PREFS, highscore);
        }

    }

    public int GetHighscore()
    {
        if (!PlayerPrefs.HasKey(HIGHSCORE_PREFS))
        {
            PlayerPrefs.SetInt(HIGHSCORE_PREFS, 0);
        }

        return PlayerPrefs.GetInt(HIGHSCORE_PREFS);
    }
}
