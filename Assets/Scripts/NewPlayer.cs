using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour
{


    public static string PagerText = "";

    private static string anun;
    private static int hp;
    private static int MaxHp = 70;
    private static int power;
    private static int MaxPower = 60;
    private static int energy;
    private static int MaxEnergy = 60;
    private static double Intellect;
    private static int Psychology;
    private static int MaxPsychology = 100;
    private static double money;

    
    private static void setAnun()
    {
        anun = InputFieldToText.getAnun();
    }

    public static string getAnun()
    {
        return anun;
    }

    private static void setHp()
    {
        hp = MaxHp;
    }

    public static void setHp(int points)
    {
        if (points >= 0)
        {
            hp = points;
        }
    }

    public static int getHp()
    {
        return hp;
    }

    public static void setMaxHP(int points)
    {
        if (points >= 0)
        {
            MaxHp = points;
        }
    }

    public static int getMaxHP()
    {
        return MaxHp;
    }

    private static void setPower()
    {
        power = MaxPower;
    }

    public static void setPower(int points)
    {
        if (points >= 0)
        {
            power = points;
        }
    }

    public static int getPower()
    {
        return power;
    }

    public static void setMaxPower(int points)
    {
        if (points >= 0)
        {
            MaxPower = points;
        }
    }

    public static int getMaxPower()
    {
        return MaxPower;
    }

    private static void setEnergy()
    {
        energy = MaxEnergy;
    }

    public static void setEnergy( int points)
    {
        if (points >= 0)
        {
            energy = points;
        }
    }

    public static int getEnergy()
    {
        return energy;
    }

    public static void setMaxEnergy(int points)
    {
        if (points >= 0)
        {
            MaxEnergy = points;
        }
    }

    public static int getMaxEnergy()
    {
        return MaxEnergy;
    }

    public static void setIntellect()
    {
        Intellect = 0;
    }

    public static void setIntellect(double points)
    {
        if (points >= 0)
        {
            Intellect = points;
        }
    }

    public static double getIntellect()
    {
        return Intellect;
    }

    public static void setPsychology()
    {
        Psychology = MaxPsychology;
    }

    public static void setPsychology(int points)
    {
        if (points >= 0)
        {
            Psychology = points;
        }
    }

    public static int getPsychology()
    {
        return Psychology;
    }

    public static void setMaxPsychology(int points)
    {
        if (points >= 0)
        {
            MaxPsychology = points;
        }
    }

    public static int getMaxPsychology()
    {
        return MaxPsychology;
    }

    private static void setMoney()
    {
        money = 50;
    }

    public static void setMoney(double points)
    {
        if (points >= 0)
        {
            money = points;
        }
    }

    public static double getMoney()
    {
        return money;
    }

    public static void setPagerText(string txt)
    {
        PagerText = txt;
    }

    public static string getPagerText()
    {
        return PagerText;
    }

    public static void createNewPlayer()
    {
        setAnun();
        setHp();
        setPower();
        setEnergy();
        setIntellect();
        setPsychology();
        setMoney();
    }

}
