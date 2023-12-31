using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayingText : MonoBehaviour
{
    public TextMeshProUGUI enemyStatsText;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI statText;
    public TextMeshProUGUI buttonLText;
    public TextMeshProUGUI buttonMText;
    public TextMeshProUGUI buttonRText;
    public string dialogue;
    public string playerStats;
    public string enemyStats;
    public string bLText;
    public string bMText;
    public string bRText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dialogueText.text = dialogue;
        enemyStatsText.text = enemyStats;
        statText.text = playerStats;
        buttonLText.text = bLText;
        buttonMText.text = bMText;
        buttonRText.text = bRText;
    }
}
