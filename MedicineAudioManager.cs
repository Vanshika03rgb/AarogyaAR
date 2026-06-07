using UnityEngine;


public class MedicineAudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip welcomeClip;
    public AudioClip glucozoneClip;
    public AudioClip fericipClip;
    public AudioClip venpresClip;
    public AudioClip lumiaClip;
    public AudioClip piltopClip;
    public AudioClip wrongMedicineClip;

    public string currentMedicine = "";

    public void SetDetectedMedicine(string medicine)
{
    currentMedicine = medicine;

    Debug.Log("DETECTED MEDICINE UPDATED = " + currentMedicine);
    Debug.Log("TIME = " + Time.time);
}

    void Start()
{
    if (welcomeClip != null)
        audioSource.clip = welcomeClip;

        audioSource.Play();
}

    public void SpeakCurrentMedicine()
{
    Debug.Log("================================");
    Debug.Log("CURRENT = [" + currentMedicine + "]");
    Debug.Log("REQUIRED = [" + PrescriptionManager.requiredMedicine + "]");
    Debug.Log("================================");
    CheckPrescription();
    string detected =
        currentMedicine.Trim().ToLower();

    string required =
        PrescriptionManager.requiredMedicine
        .Trim()
        .ToLower();

    
    Debug.Log("Detected Medicine = [" + detected + "]");
    Debug.Log("Required Medicine = [" + required + "]");
    if(detected != required)
    {
        Debug.Log("WRONG MEDICINE");

        audioSource.Stop();

        audioSource.clip =
            wrongMedicineClip;

        audioSource.Play();

        return;
    }

    Debug.Log("CORRECT MEDICINE");

    switch (currentMedicine)
    {
        case "glucozone":
            audioSource.PlayOneShot(glucozoneClip);
            break;

        case "fericip":
            audioSource.PlayOneShot(fericipClip);
            break;

        case "venpres":
            audioSource.PlayOneShot(venpresClip);
            break;

        case "lumia":
            audioSource.PlayOneShot(lumiaClip);
            break;

        case "piltop":
            audioSource.PlayOneShot(piltopClip);
            break;
    }
}
    void CheckPrescription()
{
    string detected =
        currentMedicine.Trim().ToLower();

    string required =
        PrescriptionManager.requiredMedicine
        .Trim()
        .ToLower();

    Debug.Log("Detected = " + detected);
    Debug.Log("Required = " + required);

    if(detected != required)
    {
        Debug.Log("WRONG MEDICINE");

        audioSource.Stop();

        audioSource.clip =
            wrongMedicineClip;

        audioSource.Play();

        return;
    }

    Debug.Log("CORRECT MEDICINE");
}
}
