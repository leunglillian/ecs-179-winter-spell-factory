using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBombMotion : MonoBehaviour
{
    [SerializeField] private float timeStamp;

    [SerializeField] private Vector3 movementDirection;
    [SerializeField] private Vector3 rotateDirection;

    [SerializeField] private float startSpeed;
    [SerializeField] private float rotateSpeed;

    [SerializeField] private float slowFactor;

    [SerializeField] private float fastMoveTime;
    [SerializeField] private float slowMoveTime;

    private void Start()
    {
        timeStamp = Time.time;
    }

    private void Update()
    {
        if(Time.time-timeStamp <= fastMoveTime)
        {
            this.gameObject.transform.position += Time.deltaTime * movementDirection * startSpeed;
            this.gameObject.transform.eulerAngles += Time.deltaTime * rotateSpeed * rotateDirection;
        }
        else if(Time.time-timeStamp <= (fastMoveTime+slowMoveTime))
        {
            this.transform.position += slowFactor * new Vector3(1 - Mathf.Pow(1 - Mathf.Lerp(0,1,Time.deltaTime), -3), 0, 1 - Mathf.Pow(1 - Mathf.Lerp(0, 1, Time.deltaTime), 3));
            this.gameObject.transform.eulerAngles += slowFactor * Time.deltaTime * rotateSpeed * rotateDirection;
        }
        else
        {
            // SoundManager would hypothetically play SFX here.
            Debug.Log("BOOM!");
            Destroy(gameObject);
        }
    }
}
