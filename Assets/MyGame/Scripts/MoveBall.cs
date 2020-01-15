using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPositions;

    public GameObject Ball;

    int RandomPos;
    int PosBefore;

    void SatBallRandom() {
        RandomPos = 0;
        PosBefore = 4;
    }

    void Setposition() {
        Ball.transform.position = ballPositions[RandomPos].transform.position;

    }

    public void getPosBefore()
    {
        RandomPos = Random.Range(0, 4);
        if(RandomPos != PosBefore)
        {
            PosBefore = RandomPos;
            Setposition();
        }
        else
        {
            getPosBefore();
        }
    }
}
