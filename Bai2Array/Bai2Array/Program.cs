using Bai2Array.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();
            Product p1 = new Product("CPU", 750, 10, 1);
            listProduct.Add(p1);
            Product p2 = new Product("RAM", 50, 2, 2);
            listProduct.Add(p2);
            Product p3 = new Product("HDD", 70, 1, 2);
            listProduct.Add(p3);
            Product p4 = new Product("Main", 400, 3, 1);
            listProduct.Add(p4);
            Product p5 = new Product("KeyBoard", 30, 8, 4);
            listProduct.Add(p5);
            Product p6 = new Product("Mouse", 25, 50, 4);
            listProduct.Add(p6);
            Product p7 = new Product("VGA", 60, 35, 3);
            listProduct.Add(p7);
            Product p8 = new Product("Monitor", 120, 28, 2);
            listProduct.Add(p8);
            Product p9 = new Product("Case", 120, 28, 1);
            listProduct.Add(p9);
            //
            List<Category> listCategory = new List<Category>();
            Category c1 = new Category(1, "Computer");
            listCategory.Add(c1);
            Category c2 = new Category(2, "Memory");
            listCategory.Add(c2);
            Category c3 = new Category(3, "Card");
            listCategory.Add(c3);
            Category c4 = new Category(4, "Acessory");
            listCategory.Add(c4);
            sortByCategoryName(listProduct, listCategory);
            foreach (Product p in listProduct)
            {
                Console.WriteLine(p.Name + "   " + getCategoryName(p.CategoryId, listCategory));
            }
        }

        //bài 4: "Hãy viết function findProduct(listProduct, nameProduct) trả về product có tên = nameProduct truyền vào."
        static Product findProduct(List<Product> listProduct, string nameProduct)
        {
            Product result = new Product();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Name.Equals(nameProduct))
                {
                    result = listProduct[i];
                }
            }
            if (result.Name == null)
            {
                return null;
            }
            else
            {
                return result;
            }
            
        }

        //bài 5: "Hãy viết function findProductByCategory(listProduct, categoryId) trả về danh sách product có categoryId = categoryId truyền vào"
        static List<Product> findProductByCategory(List<Product> listProduct, int categoryId)
        {
            List<Product> kq = new List<Product>();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].CategoryId == (categoryId))
                {
                    kq.Add(listProduct[i]);
                }
            }
            return kq;
        }
        // bài 7: "Hãy viết function findProductByPrice(listProduct, price) trả về danh sách tên product có giá <= price truyền vào"
        static List<string> findProductByPrice(List<Product> listProduct, int price)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < listProduct.Count; i++)
            {

                if (listProduct[i].Price <= price)
                {
                    result.Add(listProduct[i].Name);
                }
            }
            return result;
        }

        //bài 11: "Hãy viết function sortByPrice(listProduct) trả về danh sách product sắp xếp theo giá từ thấp đến cao.Làm theo thuật toán buble."
        static List<Product> sortByPrice(List<Product> listProduct)
        {
            for(int i=0; i<listProduct.Count-1; i++)
            {
                for(int j = 0; j < listProduct.Count - 1; j++)
                {
                    if(listProduct[j].Price> listProduct[j + 1].Price)
                    {
                        Product p = listProduct[j];
                        listProduct[j] = listProduct[j + 1];
                        listProduct[j + 1] = p;
                    }
                }
            }
            return listProduct;
        }
        //bài 12: "Hãy viết function sortByName(listProduct) trả về danh sách product sắp xếp độ dài của tên từ cao đến thấp.Làm theo thuật toán insertion."
        static List<Product> sortByName(List<Product> listProduct)
        {
            int holePosition;
            Product valueToInsert;
            for (int i = 1; i < listProduct.Count; i++)
            {
                valueToInsert = listProduct[i];
                holePosition = i-1;
                while (holePosition >= 0 && listProduct[holePosition].Name.Length > valueToInsert.Name.Length)
                {
                    listProduct[holePosition+1] = listProduct[holePosition];
                    holePosition--;
                }
                listProduct[holePosition+1] = valueToInsert;
            }
            return listProduct;
        }

        //Bài 13: "Hãy viết function sortByCategoryName(listProduct, listCategory) trả về danh sách product sắp xếp theo category name theo thứ tự abc. .Làm theo thuật toán của bài 12."
        static List<Product> sortByCategoryName(List<Product> listProduct, List<Category> listCategory)
        {
            int holePosition;
            Product valueToInsert;
            for (int i = 1; i < listProduct.Count; i++)
            {
                valueToInsert = listProduct[i];
                holePosition = i - 1;
                //(int)[0] > (int)[0]
                while (holePosition >= 0 && getCategoryName(listProduct[holePosition].CategoryId, listCategory).CompareTo(getCategoryName(valueToInsert.CategoryId, listCategory))>0)
                {
                    listProduct[holePosition + 1] = listProduct[holePosition];
                    holePosition--;
                }
                listProduct[holePosition + 1] = valueToInsert;
            }
            return listProduct;
        }

        static string getCategoryName(int Id, List<Category> listCategory)
        {
            string kq = "";
            for(int i=0; i<listCategory.Count; i++)
            {
                if (listCategory[i].Id == Id)
                {
                    kq = listCategory[i].Name;
                }
            }
            return kq;
        }
        // Bài 14:"Hãy viết function mapProductByCategory(listProduct, listCategory) trả về danh sách product có chứa tên category tương ứng theo categoryId"
        static Dictionary<Product, string> mapProductByCategory(List<Product> listProduct, List<Category> listCategory)
        {
            Dictionary<Product, string> list = new Dictionary<Product, string>();
            for (int i= 0; i< listProduct.Count; i++)
            {
                list.Add(listProduct[i], getCategoryName(listProduct[i].CategoryId, listCategory));
            }
            return list;
        }

        // Bài 15: "Hãy viết function minByPrice(listProduct) trả về  product có giá nhỏ nhất"
        static Product minByPrice(List<Product> listProduct)
        {
            if (listProduct == null)
            {
                return null;
            }
            else
            {
                Product result = listProduct[0];
                for (int i = 1; i < listProduct.Count; i++)
                {
                    if (listProduct[i].Price < result.Price)
                    {
                        result = listProduct[i];
                    }
                }
                return result;
            }
            
        }
        //Bài 16: "Hãy viết function maxByPrice(listProduct) trả về  product có giá lớn nhất"
        static Product maxByPrice(List<Product> listProduct)
        {
            if (listProduct == null)
            {
                return null;
            }
            else
            {
                Product result = listProduct[0];
                for (int i = 1; i < listProduct.Count; i++)
                {
                    if (listProduct[i].Price > result.Price)
                    {
                        result = listProduct[i];
                    }
                }
                return result;
            }
            
        }
    }
}
