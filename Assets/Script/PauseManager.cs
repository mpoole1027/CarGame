using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseManager : MonoBehaviour
{
   public GameObject pauseMenuUI;
   private bool isPaused = false;

   void Awake()
   {
      pauseMenuUI.SetActive(false);
   }
   
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
         if (isPaused)
         {
            Resume();
         }
         else
         {
            Pause();
         }
      }
   }

   public void Resume()
   {
      Debug.Log("RESUME");
      pauseMenuUI.SetActive(false);
      Time.timeScale = 1f;
      isPaused = false;
   }

   void Pause()
   {
      Debug.Log("PAUSED");
      pauseMenuUI.SetActive(true);
      Time.timeScale = 0f;
      isPaused = true;
   }

   public void LoadMenu()
   {
      Time.timeScale = 1f;
      SceneManager.LoadScene("MainMenu");
   }
}