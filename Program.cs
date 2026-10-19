namespace LinQ_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1. Get all products from the "Seafood" category. Print each
            //product's name and price.

            //var result = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion





            #region Question 2
            //2. Get a list of only the product names from ProductList. Print
            //each name.


            //var result = ProductList.Select(p => p.ProductName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion





            #region Question 3

            //var result = ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}


            #endregion





            #region Question 4

            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}


            #endregion




            #region Question 5

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}



            #endregion





            #region Question 6

            //var result = ProductList.Select(p => new {
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            //}



            #endregion








            #region Question 7

            //var result = ProductList.Select((p, index) => new { Index = index + 1, Name = p.ProductName });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Index}. {item.Name}");
            //}



            #endregion




            #region Question 8


            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion




            #region Question 9
            //var result = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            //}



            #endregion
        }
    }
}
