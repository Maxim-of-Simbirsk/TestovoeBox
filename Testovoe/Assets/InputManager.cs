using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] InputField FieldSpeed;
    [SerializeField] InputField FieldInterval;
    [SerializeField] InputField FieldDistance;
    [SerializeField] Spawner spawner;
    CultureInfo ruRu;
    CultureInfo enUS;
    void Start()
    {
        ruRu = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
        enUS = System.Globalization.CultureInfo.GetCultureInfo("en-US");
        UpdateSpawner();
    }
    public void UpdateSpawner()
    {
        float speed = float.Parse(FieldSpeed.text, enUS);
        float interval = float.Parse(FieldInterval.text, enUS);
        float distance = float.Parse(FieldDistance.text, enUS);

        if (speed < 1f) 
        {
            FieldSpeed.text = "1";
            UpdateSpawner();
            return;
        }
        else if (speed > 10f)
        {
            FieldSpeed.text = "10";
            UpdateSpawner();
            return;
        }
        if (interval < 0.1f)
        {
            FieldInterval.text = "0.1";
            UpdateSpawner();
            return;
        }
        else if (interval > 5f)
        {
            FieldInterval.text = "5";
            UpdateSpawner();
            return;
        }
        if (distance < 5f)
        {
            FieldDistance.text = "5";
            UpdateSpawner();
            return;
        }
        else if (distance > 100f)
        {
            FieldDistance.text = "100";
            UpdateSpawner();
            return;
        }

        spawner.UpdateData(speed, interval, distance);
    }
}
