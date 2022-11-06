using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace Platformer
{
    public class GameManager : MonoBehaviour
    {
        public static float time = 0f;
        [SerializeField] TextMeshProUGUI countdownText;

        public GameObject playerGameObject;
        private PlayerController player;
        public GameObject deathPlayerPrefab;

        void Start()
        {
            player = GameObject.Find("Player").GetComponent<PlayerController>();
        }

        void Update()
        {
            if(player.deathState == true)
            {
                playerGameObject.SetActive(false);
                GameObject deathPlayer = (GameObject)Instantiate(deathPlayerPrefab, playerGameObject.transform.position, playerGameObject.transform.rotation);
                deathPlayer.transform.localScale = new Vector3(playerGameObject.transform.localScale.x, playerGameObject.transform.localScale.y, playerGameObject.transform.localScale.z);
                player.deathState = false;
                Invoke("ReloadLevel", 2);
            }

            time = Time.timeSinceLevelLoad;
            countdownText.text = time.ToString("0.0");
        }

        private void ReloadLevel()
        {
            SceneManager.LoadScene(1);
        }
    }
}
