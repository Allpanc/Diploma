using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class InstituteDisplay : MonoBehaviour
{
    [Header("Institute panel parts")]
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _contacts;
    [SerializeField] private ListItem _listItem;
    [SerializeField] private Transform _bachelorListContent;
    [SerializeField] private Transform _specialistListContent;
    [SerializeField] private TMP_Dropdown _dropdown;

    [Header("Interaction settings")]
    [SerializeField] private bool _disableCanvasAtStart = true;

    private Institute[] _institutes;
    private List<string> instituteNames = new List<string>();
    private Canvas _canvas;

    private void Start()
    {
        _institutes = JsonMaster.ParseResource<Institute>("Institutes").ToArray();
        _canvas = transform.parent.GetComponent<Canvas>();
        if (_disableCanvasAtStart)
            _canvas.enabled = false;

        if (_dropdown!=null)
        {
            foreach (Institute institute in _institutes)
                instituteNames.Add(institute._name);
            instituteNames.Add("");

            _dropdown.ClearOptions();
            _dropdown.AddOptions(instituteNames);
        }
    }

    public void ChangeDisplayedInstitute()
    {
        if (_dropdown.value<_institutes.Length)
            DisplayInstitute(_dropdown.value);
    }

    public void DisplayInstitute(int instituteId)
    {
        if (!_canvas.enabled) 
            _canvas.enabled = true;

        Debug.Log("Display institute " + instituteId);
        ClearInstituteInfo();
        _name.text = _institutes[instituteId]._name;

        foreach (Profession profession in _institutes[instituteId]._bachelorPrograms)
        {
            ListItem item = Instantiate(_listItem, _bachelorListContent);
            item.SetText(profession.ToString());
        }

        foreach (Profession profession in _institutes[instituteId]._specialistPrograms)
        {
            ListItem item = Instantiate(_listItem, _specialistListContent);
            item.SetText(profession.ToString());
        }

        _contacts.text = _institutes[instituteId]._contacts;
        AdjustFontSize();
    }

    private void ClearInstituteInfo()
    {
        _name.text = "";
        foreach (ListItem child in _bachelorListContent.GetComponentsInChildren<ListItem>())
            Destroy(child.gameObject);

        foreach (ListItem child in _specialistListContent.GetComponentsInChildren<ListItem>())
            Destroy(child.gameObject);
        _contacts.text = "";
    }

    private void AdjustFontSize()
    { 
        ListItem[] bachelorListItems = _bachelorListContent.GetComponentsInChildren<ListItem>();
        ListItem[] specialistListItems = _specialistListContent.GetComponentsInChildren<ListItem>();
        ListItem[][] lists = new ListItem[][] { bachelorListItems, specialistListItems };

        foreach (ListItem[] list in lists)
            foreach (ListItem item in list)
                item.SetFixedMinFontSize();
    }

    //private void SaveData()
    //{
    //    List<Institute> list = InstitutesData.institutes.ToList();
    //    JsonMaster.Save(list, "Institutes.json");
    //}
}
