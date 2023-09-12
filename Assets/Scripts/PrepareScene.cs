using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PrepareScene : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Quaternion _startAngle;
    [SerializeField] private UnityEngine.UI.Image _startGameInfo;
    [SerializeField] private UnityEngine.UI.Image _endGameInfo;
    [SerializeField] private UnityEngine.UI.Button _buttonOK;
    // Start is called before the first frame update
    void Start()
    {
        CollectCheckpoints.numberOfCollectedCheckpoints = 0;

        _endGameInfo.gameObject.SetActive(false);
        _buttonOK.onClick.AddListener(ButtonOKHendler);
        ChooseCar.instance.InstantiateCarAtPoint(_startPosition);

    }

    private void ButtonOKHendler()
    {
        
        _startGameInfo.gameObject.SetActive(false);
    }
}
