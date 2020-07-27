using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject NewLoadPanel;
    public GameObject SavesPanel;
    public GameObject IFPanel;

    public Button LoadButton;
    public Button NewButton;
    public Button ExitButton;

    public int New;

    // Start is called before the first frame update
    void Start()
    {
        NewLoadPanel.SetActive(false);
        SavesPanel.SetActive(false);
        IFPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 152
        if (New == 1)
        {
            Color col = LoadButton.GetComponent<Image>().color;
            col.a = 0;
            LoadButton.GetComponent<Image>().color = col;

            Color col2 = NewButton.GetComponent<Image>().color;
            col2.a = 0.5960785f;
            NewButton.GetComponent<Image>().color = col2;
        }
        if (New == 0)
        {
            Color col = NewButton.GetComponent<Image>().color;
            col.a = 0;
            NewButton.GetComponent<Image>().color = col;

            Color col2 = LoadButton.GetComponent<Image>().color;
            col2.a = 0.5960785f;
            LoadButton.GetComponent<Image>().color = col2;
        }
    }

    public void DoSaveLoadPanel()
    {
        Debug.Log("Das SaveLoadPanel wird angezeigt.");
        NewLoadPanel.SetActive(true);
        Color col = ExitButton.GetComponent<Image>().color;
        col.a = 0;
        ExitButton.GetComponent<Image>().color = col;
    }

    public void redoSaveLoad()
    {
        Debug.Log("Das SaveLoadPanel wird nichtmehr angezeigt.");
        NewLoadPanel.SetActive(false);
        SavesPanel.SetActive(false);

        Color col2 = LoadButton.GetComponent<Image>().color;
        col2.a = 0.5960785f;
        LoadButton.GetComponent<Image>().color = col2;

        Color col = NewButton.GetComponent<Image>().color;
        col.a = 0.5960785f;
        NewButton.GetComponent<Image>().color = col;

        New = 3;
    }

    public void DoSaves(int Newf)
    {
        Debug.Log("Das Saves Panel wird angezeigt.");
        Debug.Log("New: " + Newf);
        New = Newf;
        SavesPanel.SetActive(true);
    }

    public void redoSaves()
    {
        Debug.Log("Das SaveLoadPanel wird nichtmehr angezeigt.");
        SavesPanel.SetActive(false);
    }

    public void exit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}
