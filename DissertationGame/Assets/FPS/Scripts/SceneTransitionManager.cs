using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    [Header("Survey Links")]
    public string firstSurveyURL;
    public string nextSceneName;

    public void OpenFirstSurvey()
    {
        Application.OpenURL(firstSurveyURL);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
