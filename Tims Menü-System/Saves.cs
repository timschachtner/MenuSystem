using System.Collections;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;

public class Saves : MonoBehaviour
{
    [Header("PlayerPrefsNewGame")]
    public string[] PlayerPrefIntNames;
    public int[] PlayerPrefsInts;
    [Header ("Buttons")]
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    [Header("UI")]
    public InputField field;

    public TextMeshProUGUI TextButton1;
    public TextMeshProUGUI TextButton2;
    public TextMeshProUGUI TextButton3;
    public TextMeshProUGUI TextButton4;

    private bool BT1isAbleToLoad;
    private bool BT2isAbleToLoad;
    private bool BT3isAbleToLoad;
    private bool BT4isAbleToLoad;

    private string SavedName1;
    private string SavedName2;
    private string SavedName3;
    private string SavedName4;

    private int selected;
    private int New;
    public GameObject IFpanel;
    string[] lineArray;

    public GameObject MainPanel;
    public GameObject SaveLoadPanel;
    public GameObject SavesPanel;

    

    public TextAsset deutsch;
    private List<string> lineList = new List<string>();

    public string EmptyText = "empty";
    // Start is called before the first frame update
    public void ReadWordList()
    {
        // Check if file exists before reading
        if (deutsch)
        {
            string line;
            StringReader textStream = new StringReader(deutsch.text);

            while ((line = textStream.ReadLine()) != null)
            {
                // Read each line from text file and add into list
                lineList.Add(line);
            }

            textStream.Close();
        }
    }

    public string GetRandomLine()
    {
        // Returns random line from list
        return lineList[Random.Range(0, lineList.Count)];
    }

    void Start()
    {
        New = GetComponent<MainMenu>().New;
        if (New == 3)
        {
            Debug.Log("Funktioniert!");
        }

        TextButton1.text = PlayerPrefs.GetString("NameSave1");
        TextButton2.text = PlayerPrefs.GetString("NameSave2");
        TextButton3.text = PlayerPrefs.GetString("NameSave3");
        TextButton4.text = PlayerPrefs.GetString("NameSave4");

        if (PlayerPrefs.GetInt("Game1Unlocked") != 0)
        {
            BT1isAbleToLoad = true;
        }

        if (PlayerPrefs.GetInt("Game2Unlocked") != 0)
        {
            BT2isAbleToLoad = true;
        }

        if (PlayerPrefs.GetInt("Game3Unlocked") != 0)
        {
            BT3isAbleToLoad = true;
        }

        if (PlayerPrefs.GetInt("Game4Unlocked") != 0)
        {
            BT4isAbleToLoad = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        New = GetComponent<MainMenu>().New;

    }

    public void LoadLevelBT1()
    {
        if (New == 0 && BT1isAbleToLoad)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Ladt Level.");
        }
        else if (New == 1)
        {
            IFpanel.SetActive(true);
            MainPanel.SetActive(false);
            SaveLoadPanel.SetActive(false);
            SavesPanel.SetActive(false);
            selected = 1;
        }
    }

    public void LoadLevelBT2()
    {
        if (New == 0 && BT2isAbleToLoad)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Ladt Level.");
        }
        else if (New == 1)
        {
            IFpanel.SetActive(true);
            IFpanel.SetActive(true);
            MainPanel.SetActive(false);
            SaveLoadPanel.SetActive(false);
            SavesPanel.SetActive(false);
            selected = 2;
        }
    }

    public void LoadLevelBT3()
    {
        if (New == 0 && BT3isAbleToLoad)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Ladt Level.");
        }
        else if (New == 1)
        {
            IFpanel.SetActive(true);
            IFpanel.SetActive(true);
            MainPanel.SetActive(false);
            SaveLoadPanel.SetActive(false);
            SavesPanel.SetActive(false);
            selected = 3;
        }
    }

    public void LoadLevelBT4()
    {
        if (New == 0 && BT4isAbleToLoad)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Ladt Level.");
        }
        else if (New == 1)
        {
            IFpanel.SetActive(true);
            IFpanel.SetActive(true);
            MainPanel.SetActive(false);
            SaveLoadPanel.SetActive(false);
            SavesPanel.SetActive(false);
            selected = 4;
        }
    }

    public void cancelInput()
    {
        IFpanel.SetActive(false);
        MainPanel.SetActive(true);
        SaveLoadPanel.SetActive(true);
        SavesPanel.SetActive(true);
    }
    public void RandomWord()
    {
        ReadWordList();
        field.text = GetRandomLine();
    }
    public void SaveName()
    {
        //field.text = field.text.ToString();
        if (!string.IsNullOrEmpty(field.text))
        {
            if (selected == 1)
            {
                Button1.interactable = true;
                TextButton1.text = field.text;
                Debug.Log("Der Name von" + selected + "wurde gespeichert.");
                BT1isAbleToLoad = true;

                PlayerPrefs.SetString("NameSave1", field.text);
                PlayerPrefs.SetInt("Game1Unlocked", 1);

                Debug.Log("Das Spiel mit dem Namen" + PlayerPrefs.GetString("NameSave1") + " wurde erstellt! (" + PlayerPrefs.GetInt("Game1Unlocked") + ")");
            }

            if (selected == 2)
            {
                Button2.interactable = true;
                TextButton2.text = field.text;
                Debug.Log("Der Name von" + selected + "wurde gespeichert.");
                BT2isAbleToLoad = true;
                PlayerPrefs.SetString("NameSave2", field.text);
                PlayerPrefs.SetInt("Game2Unlocked", 1);

                Debug.Log("Das Spiel mit dem Namen" + PlayerPrefs.GetString("NameSave2") + " wurde erstellt! (" + PlayerPrefs.GetInt("Game2Unlocked") + ")");
            }

            if (selected == 3)
            {
                Button3.interactable = true;
                TextButton3.text = field.text;
                Debug.Log("Der Name von" + selected + "wurde gespeichert.");
                BT3isAbleToLoad = true;
                PlayerPrefs.SetString("NameSave3", field.text);

                PlayerPrefs.SetInt("Game3Unlocked", 1);

                Debug.Log("Das Spiel mit dem Namen" + PlayerPrefs.GetString("NameSave3") + " wurde erstellt! (" + PlayerPrefs.GetInt("Game3Unlocked") + ")");
            }

            if (selected == 4)
            {
                Button4.interactable = true;
                TextButton4.text = field.text;
                Debug.Log("Der Name von" + selected + "wurde gespeichert.");
                BT4isAbleToLoad = true;
                PlayerPrefs.SetString("NameSave4", field.text);

                PlayerPrefs.SetInt("Game4Unlocked", 1);

                Debug.Log("Das Spiel mit dem Namen" + PlayerPrefs.GetString("NameSave4") + " wurde erstellt! (" + PlayerPrefs.GetInt("Game4Unlocked") + ")");
            }

            for (int i = 0; i < PlayerPrefIntNames.Length; i++)
            {
                PlayerPrefs.SetInt(PlayerPrefIntNames[i] + "SaveGame" + selected, PlayerPrefsInts[i]);
                Debug.Log("Die Variable " + PlayerPrefIntNames[i] + "SaveGame" + selected + " wurde zu den PlayerPrefsHinzugefügt. Der Wert beträgt " + PlayerPrefsInts[i]);
                Debug.Log(PlayerPrefs.GetInt(PlayerPrefIntNames[i] + "SaveGame" + selected));
            }

            field.text = "";
        }
        IFpanel.SetActive(false);
        MainPanel.SetActive(true);
        SaveLoadPanel.SetActive(true);
        SavesPanel.SetActive(true);
        //SceneManager.LoadScene(1)
    }
}
