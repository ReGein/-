using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totallItemCount;
    public int stage;
    public Text stageCountText;
    public Text PlayerCountText;

    private void Awake()
    {
        stageCountText.text = "/ " + totallItemCount.ToString();
    }

    public void GetItem(int count)
    {
        PlayerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }
}
