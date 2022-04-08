using System.Data;
using System;
public static class Kata
{
    
    public static string Greet(string language)
    {
        // Creating my database for the languages.
        var lang_greets = ArraytoDatatable(new object[17, 2] {
        {"english", "Welcome"},
        {"czech", "Vitejte"},
        {"danish", "Velkomst"},
        {"dutch", "Welkom"},
        {"estonian", "Tere tulemast"},
        {"finnish", "Tervetuloa"},
        {"flemish", "Welgekomen"},
        {"french", "Bienvenue"},
        {"german", "Willkommen"},
        {"irish", "Failte"},
        {"italian", "Benvenuto"},
        {"latvian", "Gaidits"},
        {"lithuanian", "Laukiamas"},
        {"polish", "Witamy"},
        {"spanish", "Bienvenido"},
        {"swedish", "Valkommen"},
        {"welsh", "Croeso"}
        });

        // Will be default if its invalid entry
        // Will save my greet message 
        string theGreet = "Welcome";

        // Goes through the datatable row by row and finds correct greeting
        foreach (DataRow dataRow in lang_greets.Rows)
        {
            string C1rowValue = dataRow["Column1"].ToString();
            if (C1rowValue == language)
            {
                string C2rowValue = dataRow["Column2"].ToString();
                theGreet = C2rowValue;
            }

        }

        return theGreet;
    }
    public static DataTable ArraytoDatatable(Object[,] numbers)
    {
        DataTable dt = new DataTable();
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            dt.Columns.Add("Column" + (i + 1));
        }

        for (var i = 0; i < numbers.GetLength(0); ++i)
        {
            DataRow row = dt.NewRow();
            for (var j = 0; j < numbers.GetLength(1); ++j)
            {
                row[j] = numbers[i, j];
            }
            dt.Rows.Add(row);
        }
        return dt;
    }


}