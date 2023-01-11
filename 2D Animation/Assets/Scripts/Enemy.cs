using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using System.Linq;
using System;

public class Enemy : MonoBehaviour
{

    private PauseMenu UIManager;
    internal object currentFrog;

    // Start is called before the first frame update
    void Start()
    {
        UIManager  = GameObject.Find("Canvas").GetComponent<PauseMenu>();
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && UIManager.canAnswer)
        {
            UIManager.hitEnemy();

        }
    }

    
}
