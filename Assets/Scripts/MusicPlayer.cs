using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer INSTANCE = null;

	// Use this for initialization
	void Start () {
        if (INSTANCE != null)
        {
            Destroy(gameObject);
        }
        else
        {
            INSTANCE = this;
            DontDestroyOnLoad(gameObject);
        }        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
