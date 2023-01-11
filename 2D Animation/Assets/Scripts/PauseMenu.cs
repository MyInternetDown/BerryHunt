using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Enemy givenQuestions;
    public PlayerMovement player;
    public GameObject pauseMenuUI;
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject question5;
    public GameObject question6;
    public GameObject question7;
    public GameObject question8;
    public GameObject question9;
    public GameObject question10;
    public GameObject question11;
    public GameObject question12;
    public GameObject question13;
    public GameObject question14;
    public GameObject question15;
    public GameObject question16;
    public GameObject question17;
    public GameObject question18;
    public GameObject question19;
    public GameObject question20;
    public GameObject question21;
    public GameObject congratsYa;
    public TMPro.TextMeshProUGUI answersGotten;
    public int score = 0;
    public GameObject currentFrog;
    public bool canAnswer= true;
    private List<int> questionsPossible = new List<int>();
    public int selectedQuestion;
    [SerializeField]
    private int itemIndex;
    public TMPro.TextMeshProUGUI timer;
    float currentTime;
    public TMPro.TextMeshProUGUI finalTime;
    bool stopwatchActive = false;
    private bool restart = false;
    public AudioClip berrySound;
    public bool ablePause = true;
    public Player movements;


    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timer.text = time.ToString(@"mm\:ss\:fff");

        if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) && ablePause)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.R) && restart == true)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Time.timeScale = 1f;
        }

    }

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        movements = GameObject.Find("Player").GetComponent<Player>();
        for (int i = 1; i < 22; i++)
        {
            questionsPossible.Add(i);
        }
        currentTime = 0.0f;
        stopwatchActive = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CorrectAnswer()
    {
        score++;

        movements.Unfreeze();

        AudioSource.PlayClipAtPoint(berrySound, transform.position);
        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        question8.SetActive(false);
        question9.SetActive(false);
        question10.SetActive(false);
        question11.SetActive(false);
        question12.SetActive(false);
        question13.SetActive(false);
        question14.SetActive(false);
        question15.SetActive(false);
        question16.SetActive(false);
        question17.SetActive(false);
        question18.SetActive(false);
        question19.SetActive(false);
        question20.SetActive(false);
        question21.SetActive(false);
        ablePause = true;
        canAnswer = true;
        UpdateScore(score);
        questionsPossible.Remove(questionsPossible[itemIndex]);
        Destroy(currentFrog.gameObject);
    }

    public void WrongAnswer()
    {
        player.transform.position = new Vector3(12, 1, 0);

        question1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        question8.SetActive(false);
        question9.SetActive(false);
        question10.SetActive(false);
        question11.SetActive(false);
        question12.SetActive(false);
        question13.SetActive(false);
        question14.SetActive(false);
        question15.SetActive(false);
        question16.SetActive(false);
        question17.SetActive(false);
        question18.SetActive(false);
        question19.SetActive(false);
        question20.SetActive(false);
        question21.SetActive(false);
        ablePause = true;
        movements.Unfreeze();
        canAnswer = true;
        itemIndex = 0;

    }

    [System.Obsolete]
    public void hitEnemy()
    {
        ablePause = false;
        itemIndex = UnityEngine.Random.Range(1, questionsPossible.Count());
        SetQuestion(questionsPossible[itemIndex]);
    }

    public void SetQuestion(int num)
    {
        movements.Freeze();
        if (canAnswer)
        {
            canAnswer = false;
            
            if (num == 1)
            {
                question1.SetActive(true);
            }
            else if (num == 2)
            {
                question2.SetActive(true);
            }
            else if (num == 3)
            {
                question3.SetActive(true);
            }
            else if (num == 4)
            {
                question4.SetActive(true);
            }
            else if (num == 5)
            {
                question5.SetActive(true);
            }
            else if (num == 6)
            {
                question6.SetActive(true);
            }
            else if (num == 7)
            {
                question7.SetActive(true);
            }
            else if (num == 8)
            {
                question8.SetActive(true);
            }
            else if (num == 9)
            {
                question9.SetActive(true);
            }
            else if (num == 10)
            {
                question10.SetActive(true);
            }
            else if (num == 11)
            {
                question11.SetActive(true);
            }
            else if (num == 12)
            {
                question2.SetActive(true);
            }
            else if (num == 13)
            {
                question13.SetActive(true);
            }
            else if (num == 14)
            {
                question14.SetActive(true);
            }
            else if (num == 15)
            {
                question15.SetActive(true);
            }
            else if (num == 16)
            {
                question16.SetActive(true);
            }
            else if (num == 17)
            {
                question17.SetActive(true);
            }
            else if (num == 18)
            {
                question18.SetActive(true);
            }
            else if (num == 19)
            {
                question19.SetActive(true);
            }
            else if (num == 20)
            {
                question20.SetActive(true);
            }
            else if (num == 21)
            {
                question21.SetActive(true);
            }

        }
    }
    public void UpdateScore(int score)
    {
        answersGotten.text = score + " / 20";
        if (score == 20)
        {
            congratsYa.SetActive(true);
            stopwatchActive = false;
            TimeSpan time = TimeSpan.FromSeconds(currentTime);
            finalTime.text = time.ToString(@"mm\:ss\:fff");
            Time.timeScale = 0.3f;
            restart = true;
        }
    }
}
