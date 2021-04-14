using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;

            StreamReader reader;
            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
                
            }
            
            Console.WriteLine(trivia.results[0].question);

            Random rnd = new Random();
            int num = rnd.Next(1, 4);

            int[] myNum = { 1, 2, 3, 4};
            int y = 0;
            if (trivia.results[0].type == "multiple")
            {
                for (int x = 0; x < 4; ++x)
                {
                    if (x != num - 1)
                    {

                        if (y < 3)
                        {
                            Console.WriteLine(myNum[x] + ". " + trivia.results[0].incorrect_answers[y]);
                        }
                        y++;
                    }
                    else
                    {
                        Console.WriteLine(myNum[x] + ". " + trivia.results[0].correct_answer);
                    }
                }
            }
            else
            {
                
            }

            Console.Write("Please enter your answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            
        }
    }
}
