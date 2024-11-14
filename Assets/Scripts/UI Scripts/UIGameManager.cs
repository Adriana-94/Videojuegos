using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    private Animator animator;
    private bool isNotification;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (GameManager.instance.isFull && !isNotification)
        {
            StartCoroutine(MoveNotification());
            
        }
    }

    private IEnumerator MoveNotification()
    {
        isNotification = true;
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Restart");
        GameManager.instance.isFull = false;
        isNotification = false;
    }
}
