using UnityEngine;

public class PrescriptionManager : MonoBehaviour
{
    public static string requiredMedicine = "fericip";

    public void SetMedicine(string medicine)
    {
        requiredMedicine = medicine;

        Debug.Log(
            "Prescribed Medicine = " +
            requiredMedicine
        );
    }
}
