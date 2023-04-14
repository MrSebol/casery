// Caesar szyfr
//zddefinuj string do zaszyfrowania 
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia ";
//zamienimay na wielkie litery
clearText = clearText.ToUpper();
// lteruj przez cały tekst litera po literze
//deklarujemy string wynikowy
string encryptadedText = "";
foreach(char c in clearText)
{
    //wyciągamy kod ascii danej litery
    // w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
    int asciiCode = (int)c;
    //dodajemy wartośc klucza
    asciiCode += 3;
    //zamieniamy kod z powrotem na znak
    char encrypatedChar = (char)asciiCode;
    //dopisujemy do szyfru
    encryptadedText+= encrypatedChar;
}
Console.WriteLine("Zaszyforwany tekst:" + encryptadedText);