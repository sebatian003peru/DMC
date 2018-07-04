using UnityEngine.SceneManagement;

public class ExitPause : ManagerMenu {
    Scene ActualScene;

    public override void Options()
    {
        ActualScene = SceneManager.GetActiveScene();
        if (ActualScene.name == "MainMenu")
        {
            Optiones.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
}
