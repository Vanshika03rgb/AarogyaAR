using UnityEngine;

public class EmergencyContact : MonoBehaviour
{
    public string phoneNumber = "9041664042";

    public void CallEmergencyContact()
    {
        Application.OpenURL("tel:" + phoneNumber);

        Debug.Log("Calling: " + phoneNumber);
    }
}

