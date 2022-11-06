using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace Platformer
{
    public class SwapScene : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI finalScore;

        public void Start()
        {
            finalScore.text = GameManager.time.ToString("0.0");
        }

        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void Menu()
        {
            SceneManager.LoadScene(0);
        }
    }
}
