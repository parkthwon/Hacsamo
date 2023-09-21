using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // 맵2로 전환
   public void OnClickMap2()
   {
        // Scene MAP2 로 변경할 것
        SceneManager.LoadScene("Map2");
   }

    public void OnClickOut()
    {
        // 게임창 나가기
        Application.Quit();
    }
}
