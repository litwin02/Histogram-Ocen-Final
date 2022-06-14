using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
// Kierunek: Informatyka Rok I Semestr II
// Przedmiot: Podstawy Programowania
// Tytuł projektu: Histogram ocen
// Wykonawcy: Bartosz Woliński, Jakub Litwin, Jakub Miotk, Przemysław Okun
namespace Histogram_Ocen
{
    public class Histogram
    {
        public Histogram(string file_string) // Deklaracje zmiennych dla histogramu oraz zawartości pliku.
        {
            FileContent = file_string;
        }
        public string FileContent { get; set; } 
        public int[] Review { get; set; }
        public int[] Occuarance { get; set; }
        public int AxisX_min { get; set; }
        public int AxisX_max { get; set; }
        public int Freq { get; set; }
        public bool isEmpty { get; set; }
        public List<int> Marks { get; set; }
        public int ParsingStringToInt(string data) // Funkcja zamiany typu String na typ Int.
        {
            int result = 0;
            int.TryParse(data, out result);
            return result;
        }
        public void GenerateHistogram() // Generowanie histogramu za pomocą listy, do której zapisujemy liczby z wybranego pliku.
        {
            Marks = new List<int>();
            SearchForNumbers(Marks);
            if (Marks.Count == 0)
                isEmpty = true;
            else
                CreateListOfReviews();
        }
        public void SearchForNumbers(List<int> list) // Wyszukiwanie liczb w pliku tekstowym i dodawanie ich do listy. 
        {
            string reg_pattern_for_numbers = @"\d+"; // Deklaracja filtru dla znajdywania liczb.
            bool containsInt = FileContent.Any(char.IsDigit);
            if (containsInt == true)
            {
                Regex regex = new Regex(reg_pattern_for_numbers);
                foreach (Match match in regex.Matches(FileContent))
                {
                    list.Add(ParsingStringToInt(match.Value)); // Zmieniany jest typ String na Int.
                }
            }
        }
        public void CreateListOfReviews() 
        { 
            AxisX_min = Marks.Min(); // Określanie początku wykresu.
            AxisX_max = Marks.Max();
            Freq = AxisX_max-AxisX_min+1; // Określanie zakresu wykresu.
            Review = Marks.ToArray();
            Occuarance = new int[Freq]; // Tworzenie tablicy o wielkości równej zakresowi wykresu.
            for(int i=0; i<Review.Length; i++)
            {
                int index = Review[i] - AxisX_min;
                Occuarance[index]++;
            }
        }
    }
}
