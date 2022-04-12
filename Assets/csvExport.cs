using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class csvExport : MonoBehaviour
{
    public string filename = "";
    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/export.csv";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExportData() {
        TextWriter tw = new StreamWriter(filename,false);
        tw.WriteLine("Variable,Data");
        tw.Close();

        tw = new StreamWriter(filename,true);
        
    }
}
