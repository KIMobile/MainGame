using UnityEngine;

public class Changes : MonoBehaviour
{


    public void selectFirstHostel()
    {
        NewPlayer.setHotelPrice(0.1);
        NewPlayer.setPagerText("Ayjm du unes gisherakaci tex...");
    }


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

    public void Sleep4Hour()
    {
        int newPower = NewPlayer.getPower();
        newPower += 30;
        if (newPower >= NewPlayer.getMaxPower())
        {
            NewPlayer.setPower(NewPlayer.getMaxPower());
        } else
        {
            NewPlayer.setPower(newPower);
        }
        NewPlayer.setPsychology(NewPlayer.getPsychology() + 2);
        NewPlayer.setHour(NewPlayer.getHour() + 4);
        NewPlayer.setPagerText("Du hangstacar 4 jam. Mi tetev snvi u noric ashxatel");
    }

    public void Sleep8Hour()
    {
        NewPlayer.setPower(NewPlayer.getMaxPower());
        NewPlayer.setPsychology(NewPlayer.getPsychology() + 5);
        NewPlayer.setHour(NewPlayer.getHour() + 8);
        NewPlayer.setPagerText("Du hangstacar 8 jam. Dzeeeec... Bayc bessamt sovac em");
    }

    public void LearnAlphabet()
    {
        if((NewPlayer.getPsychology() >= 15) && (NewPlayer.getMoney() >= 2.5) && (NewPlayer.getEnergy() >= 50) && (NewPlayer.getPower() >= 40))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 2.5;
            NewPlayer.setMoney(newMoney);
            int newPsycho = NewPlayer.getPsychology();
            newPsycho -= 15;
            NewPlayer.setPsychology(newPsycho);
            int newPower = NewPlayer.getPower();
            newPower -= 40;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 50;
            NewPlayer.setEnergy(newEnergy);
            double newIntellect = NewPlayer.getIntellect();
            newIntellect += 0.1;
            NewPlayer.setIntellect(newIntellect);
            NewPlayer.setHour(NewPlayer.getHour() + 5);
            NewPlayer.setPagerText("Ayjm du gites tarery ev karox es kardal.");
        } else
        {
            NewPlayer.setPagerText("Brat, chto to nitoya... Karoxa sovacs?");
        }
    }

    public void LearnDigits()
    {
        if ((NewPlayer.getPsychology() >= 15) && (NewPlayer.getMoney() >= 2.5) && (NewPlayer.getEnergy() >= 50) && (NewPlayer.getPower() >= 40))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 2.5;
            NewPlayer.setMoney(newMoney);
            int newPsycho = NewPlayer.getPsychology();
            newPsycho -= 15;
            NewPlayer.setPsychology(newPsycho);
            int newPower = NewPlayer.getPower();
            newPower -= 40;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 50;
            NewPlayer.setEnergy(newEnergy);
            double newIntellect = NewPlayer.getIntellect();
            newIntellect += 0.1;
            NewPlayer.setIntellect(newIntellect);
            NewPlayer.setHour(NewPlayer.getHour() + 5);
            NewPlayer.setPagerText("Ayjm du gites tvery ev karox es hashvel");
        }
        else
        {
            NewPlayer.setPagerText("Brat, chto to nitoya... Karoxa pox chonis?");
        }
    }

    public void TrainMaxHp()
    {
        if ((NewPlayer.getMoney() >= 0.5) && (NewPlayer.getEnergy() >= 30) && (NewPlayer.getPower() >= 40))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 0.5;
            NewPlayer.setMoney(newMoney);
            int newPsycho = NewPlayer.getPsychology();
            newPsycho += 4;
            NewPlayer.setPsychology(newPsycho);
            int newPower = NewPlayer.getPower();
            newPower -= 40;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 30;
            NewPlayer.setEnergy(newEnergy);
            NewPlayer.setHour(NewPlayer.getHour() + 2);
            NewPlayer.changeHpTrainingProgress();
            NewPlayer.setPagerText("Ufffff...");
        }
        else
        {
            NewPlayer.setPagerText("che brat, vichak chka... to mna heto");
        }
    }

    public void TrainMaxPower()
    {
        if ((NewPlayer.getMoney() >= 0.5) && (NewPlayer.getEnergy() >= 30) && (NewPlayer.getPower() >= 40))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 0.6;
            NewPlayer.setMoney(newMoney);
            int newPsycho = NewPlayer.getPsychology();
            newPsycho += 5;
            NewPlayer.setPsychology(newPsycho);
            int newPower = NewPlayer.getPower();
            newPower -= 45;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 35;
            NewPlayer.setEnergy(newEnergy);
            NewPlayer.setMinute(NewPlayer.getMinute() + 30);
            NewPlayer.setHour(NewPlayer.getHour() + 2);
            NewPlayer.changePowerTrainingProgress();
            NewPlayer.setPagerText("Ufffff...");
        }
        else
        {
            NewPlayer.setPagerText("che brat, vichak chka, esoranc hognacm... to mna heto");
        }
    }

    public void TrainMaxEnergy()
    {
        if ((NewPlayer.getMoney() >= 0.5) && (NewPlayer.getEnergy() >= 30) && (NewPlayer.getPower() >= 40))
        {
            double newMoney = NewPlayer.getMoney();
            newMoney -= 0.5;
            NewPlayer.setMoney(newMoney);
            int newPsycho = NewPlayer.getPsychology();
            newPsycho += 4;
            NewPlayer.setPsychology(newPsycho);
            int newPower = NewPlayer.getPower();
            newPower -= 40;
            NewPlayer.setPower(newPower);
            int newEnergy = NewPlayer.getEnergy();
            newEnergy -= 30;
            NewPlayer.setEnergy(newEnergy);
            NewPlayer.setHour(NewPlayer.getHour() + 2);
            NewPlayer.changeEnergyTrainingProgress();
            NewPlayer.setPagerText("Ufffff...");
        }
        else
        {
            NewPlayer.setPagerText("vay qu ara... hla et el ka?... to patar shunch qashim");
        }
    }

}
