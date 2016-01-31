using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("TimeRemaining", 30);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void InitiateGameplay()
    {
        var persistentData = GameObject.Find("PersistentData");
        var _persistentData = persistentData.GetComponent<PersistentDataScript>();
        _persistentData.TimeRemaining = PlayerPrefs.GetInt("TimeRemaining");
        SceneManager.LoadScene("Bedroom");
    }

}
