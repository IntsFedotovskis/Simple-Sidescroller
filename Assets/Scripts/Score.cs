using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score Instance;
    public Text text;
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeScore(int coins)
    {
        _score += coins;
        text.text = $"X{_score}";
    }
}
