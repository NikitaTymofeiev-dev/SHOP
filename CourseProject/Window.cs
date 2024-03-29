﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject
{
    class Window 
    {
        private static List<Cell> FoodInWindow { get; set; }


        public Window()
        {
            FoodInWindow = fillProductsInWindow();
        }

        private static List<Cell> fillProductsInWindow()
        {

            List<Cell> window = new List<Cell>();

            for (int cell = 0; cell < 5; cell++)
            {
               window.Add(new Cell());
            }

            return window;
        }

        public double  СalculateSumm(int id, int count)
        {
            Cell cell = FoodInWindow[id];   
            return cell.CalculateSumm(id,count);
        }

        public static void DeleteFoodFromCell(int id)
        {
            FoodInWindow.RemoveAt(id);
            FoodInWindow.Add(Storage.GiveProductToCell());
        }

        public override string ToString()
        {
            var iter = 1;

            foreach (var product in FoodInWindow)
            {
                Console.WriteLine(iter +" "+ product.ToString());
                iter++;
            }

            return "";
        } 
    }
}
