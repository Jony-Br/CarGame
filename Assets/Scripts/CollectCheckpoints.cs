using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectCheckpoints : MonoBehaviour
{
    public static int numberOfCollectedCheckpoints { get; set;}
    [SerializeField] private GameObject finishCheckpoint;
    [SerializeField] private TextMeshProUGUI _textCollectedCheckpoints;
    [SerializeField] private UnityEngine.UI.Image _endGameInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfCollectedCheckpoints == 4)
        {
            finishCheckpoint.SetActive(true);
            
        }
        if (numberOfCollectedCheckpoints == 5)
        {
            _endGameInfo.gameObject.SetActive(true);
        }

        _textCollectedCheckpoints.text =  numberOfCollectedCheckpoints.ToString();

    }
}
