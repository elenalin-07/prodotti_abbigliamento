string filePath = "prodotti_abbligliamento_aggiornati.txt";

string[] prodotti = File.ReadAllLines("prodotti_abbigliamento.txt");
string[] strings = new string[5];
float prezzo;

StreamWriter writer = new StreamWriter(filePath);

StreamWriter writer_sport = new StreamWriter("sport.txt");
StreamWriter writer_shoes = new StreamWriter("shoes.txt");
StreamWriter writer_donna = new StreamWriter("donna.txt");
StreamWriter writer_uomo = new StreamWriter("uomo.txt");
StreamWriter writer_bambino = new StreamWriter("bambino.txt");
StreamWriter writer_accessori = new StreamWriter("accessori.txt");

for (int i = 0; i < prodotti.Length; i++)
{
    strings = prodotti[i].Split(",");

    if (i != 0)
    {
        strings[3] = strings[3].Replace(".", ",");
        prezzo = float.Parse(strings[3]) + float.Parse(strings[3]) * 10 / 100;
        strings[3] = prezzo.ToString();

        if (strings.Contains("Sport"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_sport.Write(strings[j] + " ");
            }
            writer_sport.WriteLine();
        }
        else if (strings.Contains("Shoes"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_shoes.Write(strings[j] + " ");
            }
            writer_shoes.WriteLine();
        }
        else if (strings.Contains("Donna"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_donna.Write(strings[j] + " ");
            }
            writer_donna.WriteLine();
        }
        else if (strings.Contains("Uomo"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_uomo.Write(strings[j] + " ");
            }
            writer_uomo.WriteLine();
        }
        else if (strings.Contains("Bambino"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_bambino.Write(strings[j] + " ");
            }
            writer_bambino.WriteLine();
        }
        else if (strings.Contains("Accessori"))
        {
            for (int j = 0; j < strings.Length; j++)
            {
                writer_accessori.Write(strings[j] + " ");
            }
            writer_accessori.WriteLine();
        }
    }

    for (int j = 0; j < strings.Length; j++)
    {
        writer.Write(strings[j] + " ");   
    }
    writer.WriteLine();
}

writer.Close();

writer_sport.Close();
writer_shoes.Close();
writer_donna.Close();
writer_uomo.Close();
writer_bambino.Close();
writer_accessori.Close();
