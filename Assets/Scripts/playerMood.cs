using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class playerMood : MonoBehaviour
{
    public int mood = 100;
    public TextMeshProUGUI moodNum;
    public Image moodImg;
    public Sprite smile1;
    public Sprite smile2;
    public Sprite smile3;
    public Sprite smile4;
    public Sprite smile5;
    public LoadScene lscene;

    // Start is called before the first frame update
    void Start()
    {
        moodImg.sprite = smile1;
    }

    // Update is called once per frame
    void Update()
    {
        moodNum.text = mood.ToString();

        if (mood <= 20)
        {
            moodImg.sprite = smile5;
        }
        else if (mood <= 45)
        {
            moodImg.sprite = smile4;
        }
        else if (mood <= 70)
        {
            moodImg.sprite = smile3;
        }
        else if (mood <= 90)
        {
            moodImg.sprite = smile2;
        }

        if (mood <= 0)
        {
            Debug.Log("scenechange");
            lscene.ChangToScene("StartScene");
        }
    }
}
