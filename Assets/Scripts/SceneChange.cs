using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    

    public static void startGame()
    {
        NewPlayer.createNewPlayer();
        SceneManager.LoadScene("SelectHostel");
    }

    public static void toUserScene()
    {
        SceneManager.LoadScene("UserScene");
        NewPlayer.setPagerText("Welcome to the Real Life!");
    }

    public void GnalXanut()
    {
        SceneManager.LoadScene("Xanut");
        NewPlayer.setPagerText("Bari galust Xanut. inch kcankanaq gnel?");
    }

    public void GtnelAshxatanq()
    {
        SceneManager.LoadScene("Ashxatanq");
        NewPlayer.setPagerText("Bari galust Ashxatashuka.");
    }

    public void OpenInventar()
    {
        SceneManager.LoadScene("Inventar");
        NewPlayer.setPagerText("exac-chexact esa axper...");
    }

    public void GoToSchool()
    {
        SceneManager.LoadScene("Dproc");
        NewPlayer.setPagerText("Bari galust Dproc....");
    }

    public void GoToGym()
    {
        SceneManager.LoadScene("Gym");
        NewPlayer.setPagerText("Bari galust Sportzal... Ќадо подкачатьс€, надо - надо подкачатьс€...");
    }

    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
        NewPlayer.setPagerText("Home... Sweet home...");
    }

    public void backToUserScene()
    {
        SceneManager.LoadScene("UserScene");
        NewPlayer.setPagerText("");
    }

}
