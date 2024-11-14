using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TransitionEscene : MonoBehaviour
{
    private Animator transitionAnimator;

    void Start()
    {
        transitionAnimator = GetComponent<Animator>();
    }

    
    public void LoadScene(int scene)
    {
        StartCoroutine(SceneLoad(scene));
    }

    private IEnumerator SceneLoad(int sceneIndex)
    {
        transitionAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneIndex);
    }

}
