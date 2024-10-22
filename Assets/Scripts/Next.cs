using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    // List of scene names in the order they should be loaded
    public string[] sceneNames;
    private int currentSceneIndex;

    void Start()
    {
        // Initialize the current scene index based on the active scene
        string currentSceneName = SceneManager.GetActiveScene().name;
        currentSceneIndex = System.Array.IndexOf(sceneNames, currentSceneName);
    }

    public void OnNextButtonPressed()
    {
        // Calculate the next scene index
        int nextSceneIndex = (currentSceneIndex + 1) % sceneNames.Length;

        // Load the next scene
        SceneManager.LoadScene(sceneNames[nextSceneIndex]);
    }

    public void Selesai()
    {
        SceneManager.LoadScene(0);
    }
}
