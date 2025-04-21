using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndOfDayMenu : MonoBehaviour
{
    [Header("UI Text Elements")]
    public TMP_Text statsText;
    public Button nextDayButton;
    public Button statsButton;
    public Button shopButton;
    public Button talkButton;
    public Button saveExitButton;

    private void Start()
    {
        // Contoh data (nanti ambil dari sistem kamu)
        int sortedItems = 12;
        int dismantledItems = 10;
        int misplacements = 2;
        int hiddenItems = 3;
        int hiddenTotal = 4;
        int warnings = 1;
        int wage = 85000;

        statsText.text =
            $"Barang dipilah         : {sortedItems}\n" +
            $"Barang dibongkar       : {dismantledItems}\n" +
            $"Salah tempat           : {misplacements}\n" +
            $"Barang tersembunyi     : {hiddenItems}/{hiddenTotal}\n" +
            $"Surat peringatan       : {warnings}\n" +
            $"Upah hari ini          : Rp {wage:N0}";

        // Button listeners
        nextDayButton.onClick.AddListener(GoToNextDay);
        statsButton.onClick.AddListener(OpenStats);
        shopButton.onClick.AddListener(OpenShop);
        talkButton.onClick.AddListener(OpenDialogue);
        saveExitButton.onClick.AddListener(SaveAndExit);
    }

    void GoToNextDay()
    {
        Debug.Log("Lanjut ke hari berikutnya");
        // Ganti dengan scene atau logic level berikutnya
    }

    void OpenStats()
    {
        Debug.Log("Tampilkan statistik mingguan");
    }

    void OpenShop()
    {
        Debug.Log("Masuk ke toko perlengkapan");
    }

    void OpenDialogue()
    {
        Debug.Log("Bicara dengan rekan kerja");
    }

    void SaveAndExit()
    {
        Debug.Log("Simpan dan keluar");
        Application.Quit();
    }
}
