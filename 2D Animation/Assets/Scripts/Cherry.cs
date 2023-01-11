using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    // Start is called before the first frame update
    private PauseMenu UIManager;
    private CharacterController2D controls;
    public AudioClip frog;
    // Start is called before the first frame update
    void Start()
    {
        UIManager = GameObject.Find("Canvas").GetComponent<PauseMenu>();
        controls = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(frog, transform.position);
            Destroy(this.gameObject);
            controls.JumpBoost();
            
        }

    }
}
