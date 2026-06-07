using UnityEngine;
public class MedicineSelector : MonoBehaviour
{
    public string medicineName;
    void Start()
{
    Debug.Log("START FIRED FOR " + medicineName);
}

    public void TargetFound()
{
    MedicineAudioManager manager =
        FindObjectOfType<MedicineAudioManager>();

    if(manager != null)
    {
        manager.SetDetectedMedicine(medicineName);

        Debug.Log("TARGET FOUND = " + medicineName);
    }
}

    void CheckWrongMedicine(MedicineAudioManager manager)
{
    Debug.Log("Detected Medicine = [" + medicineName + "]");
Debug.Log("Required Medicine = [" + PrescriptionManager.requiredMedicine + "]");

if(medicineName.Trim().ToLower() != PrescriptionManager.requiredMedicine.Trim().ToLower()){
    Debug.Log("WRONG MEDICINE DETECTED");
    manager.audioSource.Stop();
manager.audioSource.clip =manager.wrongMedicineClip;
manager.audioSource.Play();
}
else{
    Debug.Log("CORRECT MEDICINE");
}
}
}
