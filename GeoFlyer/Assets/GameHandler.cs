using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private FuelBar fuelBar;
    // Start is called before the first frame update
    void Start()
    {
        fuelBar.SetSize(.4f);
        

    }


}
