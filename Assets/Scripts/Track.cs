using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class Track : MonoBehaviour
{
    private GameObject _player;
    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float x = Mathf.Clamp(_player.transform.position.x, XMin, XMax);
        float y = Mathf.Clamp(_player.transform.position.y, YMin, YMax);
        gameObject.transform.position = new Vector3(x,y+1,gameObject.transform.position.z);

    }
}
