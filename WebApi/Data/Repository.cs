using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class Repository
    {
        static List<Card> cards;


        static Repository()
        {
            string str = File.ReadAllText("Cards.json");
            cards = JsonConvert.DeserializeObject<List<Card>>(str);


            //string json = JsonConvert.SerializeObject(cards);
            //File.WriteAllText("Cards.json", json);

        }


        public static IEnumerable<Card> GetCards() => cards;

        public static void AddCard(Card card)
        {
            cards.Add(card);

            string json = JsonConvert.SerializeObject(cards);
            File.WriteAllText("Cards.json", json);

        }

        public static void DeleteCard(int id)
        {
            cards.RemoveAt(id);

            string json = JsonConvert.SerializeObject(cards);
            File.WriteAllText("Cards.json", json);
        }

        public static void PutCard(int id, Card card)
        {
            cards.RemoveAt(id);
            cards.Insert(id, card);

            string json = JsonConvert.SerializeObject(cards);
            File.WriteAllText("Cards.json", json);
        }


    }
}
