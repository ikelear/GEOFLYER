using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardController : MonoBehaviour
{

    GameObject A1, A2, A3, B1, B2, B3, C1, C2, C3, D1, D2, D3, E1, E2, E3, F1, F2, F3, G1, G2, G3, H1, H2, H3, I1, I2, I3, J1, J2, J3, K1, K2, K3, L1, L2, L3, M1, M2, M3, N1, N2, N3, O1, O2, O3;
    List<GameObject> column1 = new List<GameObject>();
    List<GameObject> column2 = new List<GameObject>();
    List<GameObject> column3 = new List<GameObject>();


    List<float> highscores = new List<float>();

    private void Awake()
    {
        A1 = GameObject.Find("A1");
        A2 = GameObject.Find("A2");
        A3 = GameObject.Find("A3");
        B1 = GameObject.Find("B1");
        B2 = GameObject.Find("B2");
        B3 = GameObject.Find("B3");
        C1 = GameObject.Find("C1");
        C2 = GameObject.Find("C2");
        C3 = GameObject.Find("C3");
        D1 = GameObject.Find("D1");
        D2 = GameObject.Find("D2");
        D3 = GameObject.Find("D3");
        E1 = GameObject.Find("E1");
        E2 = GameObject.Find("E2");
        E3 = GameObject.Find("E3");
        F1 = GameObject.Find("F1");
        F2 = GameObject.Find("F2");
        F3 = GameObject.Find("F3");
        G1 = GameObject.Find("G1");
        G2 = GameObject.Find("G2");
        G3 = GameObject.Find("G3");
        H1 = GameObject.Find("H1");
        H2 = GameObject.Find("H2");
        H3 = GameObject.Find("H3");
        I1 = GameObject.Find("I1");
        I2 = GameObject.Find("I2");
        I3 = GameObject.Find("I3");
        J1 = GameObject.Find("J1");
        J2 = GameObject.Find("J2");
        J3 = GameObject.Find("J3");
        K1 = GameObject.Find("K1");
        K2 = GameObject.Find("K2");
        K3 = GameObject.Find("K3");
        L1 = GameObject.Find("L1");
        L2 = GameObject.Find("L2");
        L3 = GameObject.Find("L3");
        M1 = GameObject.Find("M1");
        M2 = GameObject.Find("M2");
        M3 = GameObject.Find("M3");
        N1 = GameObject.Find("N1");
        N2 = GameObject.Find("N2");
        N3 = GameObject.Find("N3");
        O1 = GameObject.Find("O1");
        O2 = GameObject.Find("O2");
        O3 = GameObject.Find("O3");

        column1 = new List<GameObject> { A1, B1, C1, D1, E1, F1, G1, H1, I1, J1, K1, L1, M1, N1, O1 };
        column2 = new List<GameObject> { A2, B2, C2, D2, E2, F2, G2, H2, I2, J2, K2, L2, M2, N2, O2 };
        column3 = new List<GameObject> { A3, B3, C3, D3, E3, F3, G3, H3, I3, J3, K3, L3, M3, N3, O3 };

        highscores = GlobalController.Instance.localHighScores;

        for (int i = 0; i < column1.Count; i++)
        {
            column1[i].GetComponent<Text>().text = (i + 1).ToString();
        }

        for (int i = 0; i < column3.Count; i++)
        {
            column3[i].GetComponent<Text>().text = highscores[i].ToString("n2");
        }


        
    }

    
}
