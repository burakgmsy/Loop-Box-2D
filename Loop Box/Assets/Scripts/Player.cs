using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    public TMP_Text scoreText;
    private int score = 0;
    void Update()
    {
        scoreText.text=score.ToString();
        if (GameManager.Instance.isStart)
        {
            PlayerMove();
        }
        
    }

    private void PlayerMove()
    {

        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, -90);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            //Debug.Log("GameOver");
            PlayerPrefsManager.Instance.SaveHighscore(score);
            GameManager.Instance.LoseGame();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("startpoint"))
        {
            //Debug.Log("boost");
            speed += 0.5f;
            score++;
        }
    }
}
