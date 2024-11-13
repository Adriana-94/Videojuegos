using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject controls;
    // Start is called before the first frame update 

    public void showControls()
    {
        controls.SetActive(true);
    }

    public void CloseControls()
    {
        controls.SetActive(false);
    }
}
