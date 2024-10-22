using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Jawaban : MonoBehaviour
{
    public GameObject jawabanBenar; // The object to activate
    public GameObject jawabanSalah; // The object to activate
    public float delay = 2.0f; // Delay before switching scene
    public string nextSceneName; // The name of the next scene
    public float activeTime = 1.0f; // Time the objects will be active

    // Method to be called on button press
    public void JawabanBenar()
    {
        // Activate the target object
        jawabanBenar.SetActive(true);
        // Start coroutine to deactivate the object after a while
        StartCoroutine(DeactivateAfterTime(jawabanBenar, activeTime));
        // Start the coroutine to switch scene after delay
        StartCoroutine(SwitchSceneAfterDelay());
    }

    public void JawabanSalah()
    {
        // Activate the target object
        jawabanSalah.SetActive(true);
        // Start coroutine to deactivate the object after a while
        StartCoroutine(DeactivateAfterTime(jawabanSalah, activeTime));
    }

    // Coroutine to handle delay before scene switch
    IEnumerator SwitchSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextSceneName);
    }

    // Coroutine to deactivate object after a certain time
    IEnumerator DeactivateAfterTime(GameObject obj, float time)
    {
        yield return new WaitForSeconds(time);
        obj.SetActive(false);
    }
}
