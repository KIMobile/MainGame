using UnityEngine;
using UnityEngine.UI;

public class GymTexts : MonoBehaviour
{

    public Text HpTrainingText;
    public Text PowerTrainingText;
    public Text EnergyTrainingText;

    public GameObject TrainHpButton;
    public GameObject TrainPowerButton;
    public GameObject TrainEnergyButton;

    public void ShowTrainHpButton()
    {
        TrainHpButton.SetActive(true);
    }

    public void HideTrainHpButton()
    {
        TrainHpButton.SetActive(false);
    }

    public void ShowTrainPowerButton()
    {
        TrainPowerButton.SetActive(true);
    }

    public void HideTrainPowerButton()
    {
        TrainPowerButton.SetActive(false);
    }

    public void ShowTrainEnergyButton()
    {
        TrainEnergyButton.SetActive(true);
    }

    public void HideTrainEnergyButton()
    {
        TrainEnergyButton.SetActive(false);
    }


    void Update()
    {
        if (NewPlayer.getMaxHP() < NewPlayer.getStatsMaximum())
        {
            ShowTrainHpButton();
            HpTrainingText.text = "Leave " + (100 - NewPlayer.getHpTrainingProgress()) + "% for buid-up your Maximum HP in " + NewPlayer.getHpUp() + " points";
        } else
        {
            HideTrainHpButton();
            HpTrainingText.text = "Your Maximum HP points are "+ NewPlayer.getStatsMaximum() + ", buy premium pack for buid up it";
        }

        if (NewPlayer.getMaxPower() < NewPlayer.getStatsMaximum())
        {
            ShowTrainPowerButton();
            PowerTrainingText.text = "Leave " + (100 - NewPlayer.getPowerTrainingProgress()) + "% for buid-up your Maximum Power in " + NewPlayer.getPowerUp() + " points";
        }
        else
        {
            HideTrainPowerButton();
            PowerTrainingText.text = "Your Maximum Power points are " + NewPlayer.getStatsMaximum() + ", buy premium pack for buid up it";
        }

        if (NewPlayer.getMaxEnergy() < NewPlayer.getStatsMaximum())
        {
            ShowTrainEnergyButton();
            EnergyTrainingText.text = "Leave " + (100 - NewPlayer.getEnergyTrainingProgress()) + "% for buid-up your Maximum Energy in " + NewPlayer.getEnergyUp() + " points";
        }
        else
        {
            HideTrainEnergyButton();
            EnergyTrainingText.text = "Your Maximum Energy points are " + NewPlayer.getStatsMaximum() + ", buy premium pack for buid up it";
        }

    }
}
