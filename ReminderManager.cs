using UnityEngine;
public class ReminderManager : MonoBehaviour
{public AudioSource audioSource;
    public MedicineAudioManager medicineManager;
    public AudioClip glucozoneReminder;
    public AudioClip fericipReminder;
    public AudioClip venpresReminder;
    public AudioClip lumiaReminder;
    public AudioClip piltopReminder;
    public void SetReminder(){
        string medicine = medicineManager.currentMedicine;
        Debug.Log("Reminder Set For: " + medicine);

        switch (medicine){
            case "glucozone":
                audioSource.PlayOneShot(glucozoneReminder);
                break;

            case "fericip":
                audioSource.PlayOneShot(fericipReminder);
                break;

            case "venpres":
                audioSource.PlayOneShot(venpresReminder);
                break;

            case "lumia":
                audioSource.PlayOneShot(lumiaReminder);
                break;

            case "piltop":
                audioSource.PlayOneShot(piltopReminder);
                break;

            default:
                Debug.Log("No medicine selected");
                break;
        }
    }
}
