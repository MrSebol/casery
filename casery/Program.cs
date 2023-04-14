//deklarujemy funkcję zwracającą stringa i przyjmującaą stringa jako argument
using System.Globalization;

string toAsciiCaesar(string clearText)
{
    //zamienimay na wielkie litery
    clearText = clearText.ToUpper();
    // lteruj przez cały tekst litera po literze
    //deklarujemy string wynikowy
    string encryptadedText = "";
    foreach (char c in clearText)
    {
        // pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej litery
            // w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartośc klucza
            asciiCode += 3;
            //sprwadzamy czyy nie przekroczyliśmy ostatniego znaku (z, 90)
            if (asciiCode > 90)
                //jeśli przekroczymy to cofnij o długość alfabetu
                asciiCode -= 26;
            //zamieniamy kod z powrotem na znak
            char encrypatedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptadedText += encrypatedChar;
        }
    }
    //zwroc zakodowany string
    return encryptadedText;
}

String fromAsciiCaesar(string encrypatedText)
{
    string clearText = "";
    foreach (char c in encrypatedText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej litery
            // w języku c# rzutowanie jawne z char na int powoduje pobranie
            int asciiCode = (int)c;
            asciiCode -= 3;
            if (asciiCode > 90)
                asciiCode -= 26;
            char encrypatedChar = (char)asciiCode;
            encrypatedText+= encrypatedChar;
        }// zwroc zakodowany string
        string uncryptedText = "";
    }
    return encrypatedText;
}

// Caesar szyfr
//zddefinuj string do zaszyfrowania 
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia ";


Console.WriteLine("Zaszyforwany tekst:" + fromAsciiCaesar(clearText));