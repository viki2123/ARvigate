using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Timer : MonoBehaviour
{
    // This variable determines the duration of the delay before transitioning
    public float transitionDelay = 5f;

    // This method is called automatically when the scene starts
    void Start()
    {
        // We start a coroutine called TransitionAfterDelay
        StartCoroutine(TransitionAfterDelay());
    }

    // This is the coroutine that handles the delay and scene transition
    IEnumerator TransitionAfterDelay()
    {
        // We wait for the specified delay before continuing
        yield return new WaitForSeconds(transitionDelay);

        // After the delay, we load the second scene by its name
        SceneManager.LoadScene("Sec");
    }
}