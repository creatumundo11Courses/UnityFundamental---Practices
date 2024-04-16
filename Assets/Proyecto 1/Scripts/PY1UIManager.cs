using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PY1UIManager : MonoBehaviour
{
    public Text ScoreText;

    private void Update()
    {
        ScoreText.text = PY1Player.Score.ToString();
    }
}
