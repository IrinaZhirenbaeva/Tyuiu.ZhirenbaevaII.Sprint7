using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZhirenbaevaII.Sprint7.Project.V12.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestSortMax()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"2","fewwe","fewfe","пекп56п","20","1","покупка" },        
                {"1","fewwe","fewfe","пекп56п","50","2","аренда" },       
                {"3","fewwe","fewfe","пекп56п","89","5","покупка" },
            };



            string[,] res = ds.SortMax(DataTabl, 0);
            string[,] wait =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"3","fewwe","fewfe","пекп56п","89","5","покупка" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"2","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"1","fewwe","fewfe","пекп56п","50","2","аренда" },

            };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestSortDoubleMax()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            string[,] res = ds.SortDoubleMax(DataTabl, 3);
            string[,] wait =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"3","HP","fewfe","3,0","4","64","freer" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },



            };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestSortMin()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"2","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"1","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"3","fewwe","fewfe","пекп56п","89","5","покупка" },
            };



            string[,] res = ds.SortMin(DataTabl, 0);
            string[,] wait =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"1","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"2","fewwe","fewfe","пекп56п","50","2","аренда" },
                {"2","fewwe","fewfe","пекп56п","20","1","покупка" },
                {"3","fewwe","fewfe","пекп56п","89","5","покупка" },
            };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestSortDoubleMin()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","fewwe","fewfe","2,1","16","216","аренда" },
                {"2","fewwe","fewfe","2,1","16","216","покупка" },
                {"1","fewwe","fewfe","1,0","8","1024","аренда" },
                {"3","fewwe","fewfe","3,0","4","64","покупка" },
            };



            string[,] res = ds.SortDoubleMin(DataTabl, 3);
            string[,] wait =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"1","fewwe","fewfe","1,0","8","1024","аренда" },
                {"2","fewwe","fewfe","2,1","16","216","аренда" },
                {"2","fewwe","fewfe","2,1","16","216","покупка" },

                {"3","fewwe","fewfe","3,0","4","64","покупка" },


            };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestSearch()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            string[,] res = ds.Search(DataTabl, "HP");
            string[,] wait =
            {
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },


            };
            CollectionAssert.AreEqual(wait, res);
        }




        [TestMethod]
        public void TestArrayStrElements()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            string[] res = ds.ArrayStrElements(DataTabl, 4);
            string[] wait = { "16", "8", "4" };
            CollectionAssert.AreEqual(wait, res);

        }




        [TestMethod]
        public void TestArraySumOZY()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            int[] res = ds.ArraySumOZY(DataTabl, ds.ArrayStrElements(DataTabl, 4), 4);
            int[] wait = { 2, 1, 1 };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestStrWordsElements()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            string[] res = ds.ArrayStrWordsElements(DataTabl, 1);
            string[] wait = { "ACER", "ASUS", "HP" };
            CollectionAssert.AreEqual(wait, res);

        }




        [TestMethod]
        public void TestArraySumWords()
        {
            string[,] DataTabl =
            {
                {"ID","Фирма-изготовитель","Процессор","Тактовая частота","Объем ОЗУ","Объем жб","примечание" },
                {"2","ACER","fewfe","2,1","16","216","упукп" },
                {"2","ASUS","fewfe","2,1","16","216","fre" },
                {"1","HP","fewfe","1,0","8","1024","frefe" },
                {"3","HP","fewfe","3,0","4","64","freer" },
            };



            int[] res = ds.ArraySumWords(DataTabl, ds.ArrayStrWordsElements(DataTabl, 1), 1);
            int[] wait = { 1, 1, 2 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
