using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl.Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            var ville = from x in strings
                        where x.StartsWith(startCharacter)
                        where x.EndsWith(endCharacter)
                        select x;

            return ville;

        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            var listee = new List<int> { };

            foreach (var el in numbers)
            {
                if (el > limit)
                {
                    listee.Add(el);
                }
            }

            return listee;

        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            var liste = new List<int> { };
            var list2 = new List<int> { };
            foreach (var lstnum in numbers)
            {
                liste.Add(lstnum);
            }

            liste.Sort();
            liste.Reverse();

            foreach (int topn in liste.Take(limit))
            {
                list2.Add(topn);
            }

            return list2;

        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            IDictionary<string, int> retour = new Dictionary<string, int>();
            var fGrp = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            .GroupBy(z => z, (fExt, extCtr) => new
            {
                Extension = fExt,
                Count = extCtr.Count()
            });
            foreach (var m in fGrp)
            {
                retour.Add(m.Extension, m.Count);
            }
            return retour;

        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            var liste1 = new List<Item> { };
            var liste2 = new List<Client> { };
            var liste3 = new List<Purchase> { };
            var expect = new List<Tuple<string, string, int, double>> { };



            foreach (var el in items)
            {

                liste1.Add(el);

            }

            foreach (var el in clients)
            {

                liste2.Add(el);

            }

            foreach (var el in purchases)
            {

                liste3.Add(el);

            }




            foreach (var e1 in liste2)
            {

                foreach (var e2 in liste3)
                {

                    foreach (var e3 in liste1)
                    {

                        if (e1.Id == e2.ClientId && e2.ItemId == e3.Id)
                            expect.Add(new Tuple<string, string, int, double>(e1.Name, e3.Label, e2.Quantity, e3.Price));
                    }

                }

            }


            return expect;

        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
