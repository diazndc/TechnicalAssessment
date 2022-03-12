using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string json = File.ReadAllText("input.txt");
            MovieStar[] movieStars = JsonConvert.DeserializeObject<MovieStar[]>(json);

            foreach(MovieStar movieStar in movieStars)
            {
                Console.WriteLine(movieStar.Name+" "+movieStar.Surname);
                Console.WriteLine(movieStar.Sex);
                Console.WriteLine(movieStar.Nationality);
                Console.WriteLine(movieStar.CalculateAge()+"\n");
                
            }
        }
    }

    class MovieStar
    {
        [JsonProperty("dateOfBirth")]
        private string dateOfBirth;

        public string Name;
        public string Surname;
        public string Sex;
        public string Nationality;

        public int CalculateAge()
        {
            string[] now = DateTime.Now.ToUniversalTime().ToString("MM dd yyyy").Split(' ');
            int currentMonth = int.Parse(now[0]);
            int currentDay = int.Parse(now[1]);
            int currentYear = int.Parse(now[2]);

            string[] birth = DateTime.ParseExact(dateOfBirth, "MMMM dd, yyyy", CultureInfo.InvariantCulture).ToUniversalTime().ToString("MM dd yyyy").Split(' ');
            int birthMonth = int.Parse(birth[0]);
            int birthDay = int.Parse(birth[1]);
            int birthYear = int.Parse(birth[2]);

            bool fulfiled = currentMonth > birthMonth || currentMonth == birthMonth && birthDay >= currentDay;

            return fulfiled ? currentYear - birthYear : currentYear - birthYear - 1;

        }
    }
}
