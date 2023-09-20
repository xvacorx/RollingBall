using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    
    public Text scoreText; // Referencia al componente Text que mostrará el puntaje.
    public int score = 0; // Puntaje actual.
    public Text lifeText;
    private int life = 3;

    private void Start()
    {
        UpdateScoreText();
        UpdateLifeText();
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreText();
    }
    public void LoseLife(int lifeToLose)
    {
        life -= lifeToLose;
        UpdateLifeText();
    }
    private void UpdateLifeText()
    {
        if (lifeText != null)
        {
            lifeText.text = "Vidas: " + life.ToString();
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Puntaje: " + score.ToString();
        }
    }
}
