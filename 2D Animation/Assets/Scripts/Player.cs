using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PauseMenu UIManager;
    private CharacterController2D playerSpeed;
    public int score = 0;
    public Rigidbody2D m_Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        UIManager = GameObject.Find("Canvas").GetComponent<PauseMenu>();
        playerSpeed = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Frog"))
        {
            UIManager.currentFrog = other.gameObject;
        }
    }

    public void Freeze()
    {
        m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
    }

    public void Unfreeze()
    {
        m_Rigidbody.constraints = RigidbodyConstraints2D.None;
        m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    
}
