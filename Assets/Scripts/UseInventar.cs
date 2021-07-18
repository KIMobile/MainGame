using UnityEngine;

public class UseInventar : MonoBehaviour
{
    
    public static void EatOneApple()
    {
        if (NewPlayer.getApples() > 0)
        {
            int newEnergy = NewPlayer.getEnergy();
            newEnergy += 10;
            if (newEnergy >= NewPlayer.getMaxEnergy() )
            {
                NewPlayer.setEnergy(NewPlayer.getMaxEnergy());
            } else
            {
                NewPlayer.setEnergy(newEnergy);
            }
            int newApples = NewPlayer.getApples();
            newApples -= 1;
            NewPlayer.setApple(newApples);
            NewPlayer.setPagerText("Du kerar 1 xndzor");
        } else
        {
            NewPlayer.setPagerText("Du chunes vochmi xndzor");
        }

    }

    public static void EatOneMacun()
    {
        if(NewPlayer.getMacuns() > 0)
        {
            int newEnergy = NewPlayer.getEnergy();
            newEnergy += 15;
            if (newEnergy >= NewPlayer.getMaxEnergy())
            {
                NewPlayer.setEnergy(NewPlayer.getMaxEnergy());
            }
            else
            {
                NewPlayer.setEnergy(newEnergy);
            }
            int newHP = NewPlayer.getHp();
            newHP += 10;
            if(newHP >= NewPlayer.getMaxHP())
            {
                NewPlayer.setHp(NewPlayer.getMaxHP());
            } else
            {
                NewPlayer.setHp(newHP);
            }
            int newMacuns = NewPlayer.getMacuns();
            newMacuns -= 1;
            NewPlayer.setMacuns(newMacuns);
            NewPlayer.setPagerText("Du xmecir 1 shish macun");
        } else
        {
            NewPlayer.setPagerText("Macun chka, xndzor ker...");
        }
    }

}
