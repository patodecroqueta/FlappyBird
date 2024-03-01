using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
  public void Reset(){
    SceneManager.LoadScene(0);
  }
   public void Exit(){
    Application.Quit();
  }
} 