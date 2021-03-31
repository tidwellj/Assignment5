

using UnityEngine;
using UnityEngine.UI;

public class DropD1 : MonoBehaviour
{
    Dropdown m_Dropdown;
    static public string lives = "Easy";
    static public string lives1;
    //public Text m_Text;
    int m_DropdownValue;

    void Start()
    {
        m_Dropdown = GetComponent<Dropdown>();
    }

    public void Update()
    {
        m_DropdownValue = m_Dropdown.value;
        lives1 = m_Dropdown.options[m_DropdownValue].text;
        lives = lives1;
        Debug.Log(lives);

    }
}