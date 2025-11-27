using System.Runtime.CompilerServices;
using UnityEngine;

public class Study : MonoBehaviour
{
    public string say = "";
    private string said = "";
    string newsay = ("Hello! World.");
    public char text;
    public int var01 = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;
    private bool var05 = false;

    void Start()

    {
        int nevar = 10;
        Debug.Log(nevar);
        Debug.Log(nevar++);
        Debug.Log(++nevar);

        Debug.Log(Random.Range(1,100));

        Debug.Log(said);
        Debug.Log(say);
        Debug.Log(newsay);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
