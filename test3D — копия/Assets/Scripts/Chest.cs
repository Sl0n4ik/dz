using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    //private readonly int OpenTrigger = Animator.StringToHash("Open");

    public void Open()
    {
        Debug.Log("FFFFFF");
        //_animator.SetTrigger(OpenTrigger);
    }
}
