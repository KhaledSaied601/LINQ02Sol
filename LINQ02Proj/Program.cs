using static LINQ02Proj.ListGenerators;

namespace LINQ02Proj
{
    public class StringComperer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x?.ToLower().CompareTo(y.ToLower()) ?? ( y is null ? 0 : -1 );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            var dictionaryEnglish = File.ReadLines("dictionary_english.txt");


            // LINQ - Element Operators
            #region 1. Get first Product out of Stock 


            //var result = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.


            //var result = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault() ;
            //if (result == null) Console.WriteLine("No Product Found");
            //else Console.WriteLine(result);



            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Order().Where(n => n > 5).ToArray()[1];

            //Console.WriteLine(result);

            #endregion

            //LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(n => n % 2 != 0).Count();

            //Console.WriteLine(result);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //List<int> ordersNumber = CustomerList.Select(c => c.Orders.Count()).ToList();

            //for (int i = 0; i < ordersNumber.Count; i++)
            //{
            //    Console.WriteLine($"Customer : {CustomerList[i].CustomerName} , Orders Number : {ordersNumber[i]} ");
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(),c=>c.Count());


            //foreach (var item in result) 
            //Console.WriteLine($"{item.Key} : {item.Value}");
            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).


            //var result = dictionaryEnglish.Sum(s => s.Length);
            //Console.WriteLine(result); 
            #endregion


            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = dictionaryEnglish.Min(x => x.Length);
            //Console.WriteLine(result); 
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = dictionaryEnglish.Max(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = dictionaryEnglish.Average(x => x.Length);
            //Console.WriteLine(result);


            #endregion

            #region 9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(), c => c.Sum(p => p.UnitsInStock));
            //foreach (var item in result) 
            //    Console.WriteLine($"Category Name :{item.Key} , Unit in Stock:{item.Value}"); 
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(), c => c.Min(p => p.UnitPrice));
            //foreach (var item in result)
            //    Console.WriteLine($"Category Name :{item.Key} , Min Product Price :{item.Value}"); 
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //           group p by p.Category 
            //           into c
            //           let minP = c.Min(p=>p.UnitPrice)
            //           select new {Category=c.FirstOrDefault().Category.ToString(),MinPrice=minP} ;

            //foreach ( var c in result ) 
            //Console.WriteLine($"Category Name :{c.Category} , Min Product Price :{c.MinPrice}");








            #endregion





            #region 12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(), c => c.Max(p => p.UnitPrice));
            //foreach (var item in result)
            //    Console.WriteLine($"Category Name :{item.Key} ,  Max Price :{item.Value}");

            #endregion


            #region 13. Get the products with the most expensive price in each category.
            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(), c => c.OrderByDescending(p => p.UnitPrice).FirstOrDefault());
            //foreach (var item in result)
            //    Console.WriteLine($"Category Name :{item.Key} ,  Product :{item.Value}");

            #endregion


            #region 14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(p => p.Category).ToDictionary(c => c.FirstOrDefault().Category.ToString(), c => c.Average(p => p.UnitPrice));
            //foreach (var item in result)
            //    Console.WriteLine($"Category Name :{item.Key} ,  Max Price :{item.Value}");
            #endregion

            //LINQ - Ordering Operators


            #region 1. Sort a list of products by name

            //var result = ProductList.OrderBy(p => p.ProductName.Length);
            //foreach (var item in result) Console.WriteLine(item);

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.Order(new StringComperer());
            //foreach (string str in result) Console.WriteLine(str);

            #endregion



            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result) Console.WriteLine(item);

            #endregion




        }
    }
}
