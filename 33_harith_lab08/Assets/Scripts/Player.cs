using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float Score;
    public Text ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        ScoreDisplay.GetComponent<Text>().text = "Score :" + Score;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            Score += 1;
        }
    }
}
