using UnityEngine;

public class ObjekPenyimpanan : MonoBehaviour
{
    // Menggunakan array untuk beberapa objek
    public GameObject[] objekArray;  // Ini akan muncul sebagai beberapa slot di Inspector
    public GameObject boxPenyimpanan;

    public void MasukkanKeBox()
    {
        foreach (GameObject objek in objekArray)
        {
            // Set objek sebagai child dari box penyimpanan
            objek.transform.SetParent(boxPenyimpanan.transform);

            // Set posisi objek agar berada di dalam box (posisi relatif terhadap box)
            objek.transform.localPosition = Vector3.zero;  // Bisa disesuaikan sesuai kebutuhan
        }
    }
}
