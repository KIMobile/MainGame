using UnityEngine.UI;
using UnityEngine;

public class ShowInventar : MonoBehaviour
{

    public Text Apples;
    public Text Macuns;


    // Update is called once per frame
    void Update()
    {
        Apples.text = "Du unes " + NewPlayer.getApples().ToString() + " Xndzor";
        Macuns.text = "Du unes " + NewPlayer.getMacuns().ToString() + " Macun";
    }
}
