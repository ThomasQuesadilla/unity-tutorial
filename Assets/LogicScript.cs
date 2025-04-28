using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverScreen;

    private void Start()
    {
        pipeSpawner.onSpawn += SubscribeOnPass;
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        GameObject.FindGameObjectWithTag("Player").GetComponent<birbScript>().birbDead += GameOver;
    }

    private void SubscribeOnPass(passedPipe pipePass)
    {
        pipePass.onPass += Increment;
    }

    [ContextMenu("Increase Score")]
    public void Increment()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
