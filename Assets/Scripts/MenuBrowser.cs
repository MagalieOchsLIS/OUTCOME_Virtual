using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBrowser : MonoBehaviour
{
    public GameObject feedbackButtonPrefab;
    public GameObject feedbackButtonMenu;
    List<FeedbackElement> elements;
    Text text;

    public GameObject avatarButtonPrefab;
    public GameObject femaleAvatarButtonMenu;
    public GameObject maleAvatarButtonMenu;
    List<GameObject> avatarList;

    int listLength = 3;


    private void SelectFeedback(int feedbackId)
    {

        AppManager.Instance.LoadFeedbackRessources(feedbackId);

    }
    private void SelectAvatar(GameObject avatar)
    {
        AppManager.Instance.ChangeActiveAvatar(avatar);
    }

    void BuildAvatarMenu(List<GameObject> avatars, GameObject menu, string text)
    {
        int i = 1;
        foreach (GameObject avatar in avatars)
        {

            GameObject newButton = Instantiate(avatarButtonPrefab, menu.transform);
            newButton.GetComponentInChildren<Text>().text = text + " " + i;
            newButton.GetComponent<Button>().onClick.AddListener(() => SelectAvatar(avatar));
            
            i++;
        }
    }

    IEnumerator Refresh()
    {
        femaleAvatarButtonMenu.transform.parent.parent.GetComponent<LayoutElement>().enabled = false;
        yield return new WaitForSeconds(0.1f);
        
        femaleAvatarButtonMenu.transform.parent.parent.GetComponent<LayoutElement>().enabled = true;
    }

    void Start()
    {
        elements = AppManager.Instance.GetFeedbackList().elements;
        listLength = elements.Count;

        for (int i = 0; i < listLength ; i++)
        {
            GameObject newButton = Instantiate(feedbackButtonPrefab, feedbackButtonMenu.transform);

            int fbNum = i;


            newButton.GetComponentInChildren<Text>().text = elements[i].name;
            newButton.GetComponent<Button>().onClick.AddListener( () => SelectFeedback(fbNum) );
        }


        avatarList = new List<GameObject>(AppManager.Instance.GetFemaleAvatars());
        
        
        BuildAvatarMenu(avatarList, femaleAvatarButtonMenu, "Female");

        avatarList = new List<GameObject>(AppManager.Instance.GetMaleAvatars());
        BuildAvatarMenu(avatarList, maleAvatarButtonMenu, "Male");

        StartCoroutine( Refresh());
    }


}
