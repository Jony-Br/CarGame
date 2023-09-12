using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChooseCar : MonoBehaviour
{


    [SerializeField] private GameObject[] _carArray;
    [SerializeField] private Transform _mainSpawnPoint;
    [SerializeField] private Button _leftButton;
    [SerializeField] private Button _rightButton;
    public int NumberOfCar = 0;
    public GameObject Car; 


    public static ChooseCar instance;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(this);
            return;
        }
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        InstantiateCarAtPoint(_mainSpawnPoint);


        _leftButton.onClick.AddListener(LeftButtonHandle);
        _rightButton.onClick.AddListener(RightButtonHandle);
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

     
    }

    void LeftButtonHandle()
    {
        Debug.Log("LeftButton work");
        DestroyImmediate(Car);
        
        if (NumberOfCar <= 0)
        {
            NumberOfCar = _carArray.Length - 1;
            InstantiateCarAtPoint(_mainSpawnPoint);
        }
        else
        {
            NumberOfCar--;
            InstantiateCarAtPoint(_mainSpawnPoint);
        }
    }

    void RightButtonHandle()
    {

        Debug.Log("RightButton work");
        DestroyImmediate(Car);
        
        if (NumberOfCar >= (_carArray.Length - 1) )
        {
            NumberOfCar = 0;
            InstantiateCarAtPoint(_mainSpawnPoint);
        }
        else
        {
            NumberOfCar++;
            InstantiateCarAtPoint(_mainSpawnPoint);
        }
    }

    public void InstantiateCarAtPoint(Transform spawnPoint)
    {
        Car = Instantiate(_carArray[NumberOfCar], spawnPoint);
    }
}
