using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            target.SetActive(!target.activeSelf);
        }
    }
}
