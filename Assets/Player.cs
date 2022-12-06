using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player instance;

    public float speed;
    private int dir = 1;

    [SerializeField] private GameObject lose;

    [SerializeField] private TextMeshProUGUI scoreT;
    [SerializeField] private TextMeshProUGUI scoreT2;


    public int score;

    [SerializeField] private GameObject ball;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (transform.position.x > 1.6f || transform.position.x < -1.6f)
        {
            dir *= -1;
        }

        transform.position += Vector3.right * speed * dir * Time.deltaTime;

        scoreT.text = score.ToString();
        scoreT2.text = score.ToString();

    }
    public void Click()
    {
        Instantiate(ball, new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z), Quaternion.identity);
    }

    public void death()
    {
        lose.SetActive(true);
    }

    public void Home()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
