using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;

    public int CurrentBalance {get { return currentBalance;}}

    [SerializeField] TextMeshProUGUI goldDisplay;

    private void Awake() 
    {
        currentBalance = startingBalance;
    }

    private void Start() 
    {
        UpdateDisplay();
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void Withdraw(int amount) 
    {
        currentBalance -= Mathf.Abs(amount);

        if (currentBalance < 0)
        {
            //lose the game
            ReloadScene();
        }
        UpdateDisplay();
    }

    void UpdateDisplay() 
    {
        goldDisplay.text = "Gold: " + currentBalance;
    }

    void ReloadScene() 
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
