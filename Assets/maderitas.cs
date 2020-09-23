using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maderitas : MonoBehaviour
{
    public static int maderas;

    public Text _text;
    // Start is called before the first frame update
    void Start()
    {
        maderas = 0;
    }

    // Update is called once per frame
    void Update()
    {    
        _text = GetComponent<Text>();
        
        _text.text=("Wood:"+maderas);

    }
}
