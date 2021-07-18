using UnityEngine;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour
{

    public Text userName;
    public Text healthPoints;
    public Text powerPoints;
    public Text energyPoints;
    public Text IntellectPoints;
    public Text PsychologyPoints;
    public Text moneyCount;

    public Text Pager;


    void Update()
    {
        userName.text = NewPlayer.getAnun();
        healthPoints.text = NewPlayer.getHp().ToString() + "/" + NewPlayer.getMaxHP().ToString();
        powerPoints.text = NewPlayer.getPower().ToString() + "/" + NewPlayer.getMaxPower().ToString();
        energyPoints.text = NewPlayer.getEnergy().ToString() + "/" + NewPlayer.getMaxEnergy().ToString();
        IntellectPoints.text = NewPlayer.getIntellect().ToString();
        PsychologyPoints.text = NewPlayer.getPsychology().ToString() + "/" + NewPlayer.getMaxPsychology().ToString();
        moneyCount.text = NewPlayer.getMoney().ToString() + "$";
        Pager.text = NewPlayer.getPagerText();
    }

}
