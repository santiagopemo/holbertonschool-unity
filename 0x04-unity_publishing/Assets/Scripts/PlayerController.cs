using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score;
    public int health;
    public Text scoreText;
    public Text healthText;
    public Text winLoseText;
    public Image winLoseBG;

    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
        score = 0;
        health = 5;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            score++;
            other.gameObject.SetActive(false);
            // Debug.Log("Score: " + score);
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            health--;
            // Debug.Log("Health: " + health);
            SetHealthText();
        }
        if (other.gameObject.CompareTag("Goal"))
        {
            // Debug.Log("You win!");
            SetWinText();
            StartCoroutine(LoadScene(3));
        }
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(movement * speed);
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score;
    }
    void SetHealthText()
    {
        healthText.text = "Health: " + health;
    }

    void SetWinText()
    {
        winLoseText.text = "You Win!";
        winLoseBG.gameObject.SetActive(true);
        winLoseText.color = Color.black;
        winLoseBG.color = Color.green;        
    }

    void SetLoseText()
    {
        winLoseText.text = "Game Over!";
        winLoseBG.gameObject.SetActive(true);
        winLoseText.color = Color.white;
        winLoseBG.color = Color.red;
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("maze");
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            // Debug.Log("Game Over!");
            SetLoseText();
            // SceneManager.LoadScene("maze");
            StartCoroutine(LoadScene(3));
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
