string filePath = "prodotti_abbligliamento_aggiornati.txt";
string filePath1;



string[] prodotti = File.ReadAllLines("prodotti_abbigliamento.txt");
string[] strings = new string[5];
float prezzo;

StreamWriter writer = new StreamWriter(filePath);
StreamWriter writer1 = new StreamWriter(filePath1);


for (int i = 0; i < prodotti.Length; i++)
{
    strings = prodotti[i].Split(",");

    if (i != 0)
    {
        strings[3] = strings[3].Replace(".", ",");
        prezzo = float.Parse(strings[3]) + float.Parse(strings[3]) * 10 / 100;
        strings[3] = prezzo.ToString();

        if (strings[2] == "Sport")
        {

        }
        else if (strings[2] == "Shoes")
        {

        }
        else if (strings[2] == "Donna")
        {

        }
        else if (strings[2] == "Uomo")
        {

        }
        else if (strings[2] == "Bambino")
        {

        }
        else if (strings[2] == "Accessori")
        {

        }
    }

    for (int j = 0; j < strings.Length; j++)
    {
        writer.Write(strings[j] + " ");   
    }
    writer.WriteLine();
}

writer.Close();