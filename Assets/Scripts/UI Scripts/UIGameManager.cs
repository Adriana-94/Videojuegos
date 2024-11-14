using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameManager : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    private IEnumerator MoveNotification()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(2f);
        animator.SetTrigger("Restart");
    }
}
