using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class APS
    {
        public String name;
        public int number;
        public String addres;
        public int countUsers;
        public float usersPay;
        public String tarif;
        public int freeLines;



        public APS()
        {
            name = "";
            number = 0;
            addres = "";
            countUsers = 0;
            usersPay = 0;
            tarif = "";
            freeLines = 0;
        }
        public APS(String name)
        {
            this.name = name;
            number = 0;
            addres = "";
            countUsers = 0;
            usersPay = 0;
            tarif = "";
            freeLines = 0;
        }
        public APS(String name, int number)
        {
            this.name = name;
            this.number = number;
            addres = "";
            countUsers = 0;
            usersPay = 0;
            tarif = "";
            freeLines = 0;
        }

        public APS(string name, int number, string addres, int countUsers, float usersPay, string tarif, int freeLines)
        {
            this.name = name;
            this.number = number;
            this.addres = addres;
            this.countUsers = countUsers;
            this.usersPay = usersPay;
            this.tarif = tarif;
            this.freeLines = freeLines;
        }

        public override String ToString() 
        {
            return "Название: "
                + name
                + "\nномер: "
                + number.ToString()
                + "\nадрес: "
                + addres
                + "\nколичество пользователей: "
                + countUsers.ToString()
                + "\nАбонентская плата: "
                + usersPay.ToString()
                + "\nтариф: "
                + tarif
                + "\nсвободные линии: "
                + freeLines.ToString();
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
        public void printNumber16()
        {
            Console.WriteLine(String.Format());
        }
    }
}
