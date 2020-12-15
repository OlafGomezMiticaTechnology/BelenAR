using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChoosedLanguage", menuName = "LanguageManager")]
public class LanguageChoosed : ScriptableObject
{
    public int LanguageChoosedByUser;

    public TextData GermanSC;
    public TextData EnglishSC;
    public TextData SpanishSC;


    public void PickedLanguage(int pick)
    {
        GermanSC.SetTagData("Heilige Familie", "Drei Könige und Stern", "Ankündigung Engel und Hirten", "Canfranc International Bahnhof", "Somport Eisenbahntunnel.", "Pico del Águila", "Fotogallerien");
        EnglishSC.SetTagData("Holy Family", "Three Kings and star", "Announcing angel and shepherds", "Canfranc International Station", "Somport railway tunnel.", "Pico del Águila", "Photo gallery");
        SpanishSC.SetTagData("Sagrada Familia", "Reyes Magos y Estrella", "Ángel anunciador y pastores", "Estación Internacional de Canfranc", "Túnel ferroviario de Somport", "Pico del Águila", "Galería de fotos");

        //GermanSC.SetExperienceTagData("Wählen Sie Ihre Erfahrung", "Weihnachtskrippe", "Weihnachtskarte");
        //EnglishSC.SetExperienceTagData("Choose your experience", "Nativity scene", "Christmas card");
        //SpanishSC.SetExperienceTagData("Elige tu experiencia", "Belén", "Felicitación de navidad");

        LanguageChoosedByUser = pick;
        NextScene();
    }

    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    //public void ChangeToBelenScene()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(3);
    //}

    //public void ChangeToXmasGiftScene()
    //{
    //    UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(4);
    //}




}
