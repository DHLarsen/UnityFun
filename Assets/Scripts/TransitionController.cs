using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour
{
   public Animator animator;
   public float transistionDelayTime;

   void Awake()
    {
        animator = GameObject.Find("Transition").GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Start()
    {
        Thread.Sleep(3000);
        LoadLevel();
    }
    public void LoadLevel()
    {
        StartCoroutine(DelayLoadLevel("SampleScene"));
    }
    IEnumerator DelayLoadLevel(String scene)
    {
        animator.SetTrigger("TriggerTransition");
        yield return new WaitForSeconds(transistionDelayTime);
        SceneManager.LoadScene(scene);
    }
}
