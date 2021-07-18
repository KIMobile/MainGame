using UnityEngine;
using UnityEngine.UI;

public class Changes : MonoBehaviour
{


    public void TestWork()
    {
        if ((NewPlayer.getPower() >= 15) && (NewPlayer.getEnergy() >= 20) && (NewPlayer.getPsychology() >= 6))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney += 0.5;
            NewPlayer.setMoney(newMoney);
            int newPower = NewPlayer.getPower();
            newPower -= 15;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 20;
            NewPlayer.setEnergy(newEnergy);
            int newPsychology = NewPlayer.getPsychology();
            newPsychology -= 6;
            NewPlayer.setPsychology(newPsychology);
            NewPlayer.setPagerText("Du hajoxutyamb ashxatecir 50 cent");
        } else
        {
            NewPlayer.setPagerText("Energian, ujy kam hogebanakan vichaky tuyl chi talis ashxatel.");
        }
    }

    public void Burchik()
    {
        if ((NewPlayer.getPower() >= 35) && (NewPlayer.getEnergy() >= 50) && (NewPlayer.getPsychology() >= 10) && (NewPlayer.getHp() >= 15))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney += 1.5;
            NewPlayer.setMoney(newMoney);
            int newPower = NewPlayer.getPower();
            newPower -= 35;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 50;
            NewPlayer.setEnergy(newEnergy);
            int newPsychology = NewPlayer.getPsychology();
            newPsychology -= 10;
            NewPlayer.setPsychology(newPsychology);
            int newHP = NewPlayer.getHp();
            newHP -= 15;
            NewPlayer.setHp(newHP);
            NewPlayer.setPagerText("Du hajoxutyamb ashxatecir 1 Dollar 50 cent");
        }
        else
        {
            NewPlayer.setPagerText("Energian, ujy, aroxjutyuny kam hogebanakan vichaky tuyl chi talis ashxatel.");
        }
    }

    public void buyApple()
    {
        if (NewPlayer.getMoney() >= 0.1)
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 0.1;
            NewPlayer.setMoney(newMoney);
            int newApples = NewPlayer.getApples();
            newApples += 1;
            NewPlayer.setApple(newApples);
            NewPlayer.setPagerText("Du hajoxutyamb gnecir 1 xndzor");
        } else
        {
            NewPlayer.setPagerText("Gumary chi heriqum gnum katarelu hamar");
        }

    }

    public void buyMacun()
    {
        if (NewPlayer.getMoney() >= 2.0)
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 2.0;
            NewPlayer.setMoney(newMoney);
            int newMacuns = NewPlayer.getMacuns();
            newMacuns += 1;
            NewPlayer.setMacuns(newMacuns);
            NewPlayer.setPagerText("Du hajoxutyamb gnecir 1 shish Macun");
        }
        else
        {
            NewPlayer.setPagerText("Gumary chi heriqum gnum katarelu hamar");
        }

    }


}
