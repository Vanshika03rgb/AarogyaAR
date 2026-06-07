using TMPro;
using UnityEngine;

public class DropdownManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    public PrescriptionManager prescriptionManager;

    void Start()
    {
        OnMedicineChanged();
    }

    public void OnMedicineChanged()
    {
        string selectedMedicine =
            dropdown.options[
                dropdown.value
            ].text.ToLower();

        prescriptionManager.SetMedicine(
            selectedMedicine
        );

        Debug.Log(
            "Dropdown Selected = " +
            selectedMedicine
        );
    }
}
