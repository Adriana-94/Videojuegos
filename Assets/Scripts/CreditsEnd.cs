using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private int scene; // Nombre de la siguiente escena
    [SerializeField] private AnimationClip animationClip; // Duración de la animación en segundos

    private void Start()
    {
        // Obtén la longitud de la animación
        float animationDuration = animationClip.length;

        StartCoroutine(WaitandChangeCredits(animationDuration));
    }

    private IEnumerator WaitandChangeCredits(float animationDuration)
    {
        yield return new WaitForSeconds(animationDuration);
        SceneManager.LoadScene(scene);
    }
}
