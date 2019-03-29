using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Five_Items
    {
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string first_Item;
        public string First_Item
        {
            get { return first_Item; }
            set { first_Item = value; }
        }

        private string second_Item;
        public string Second_Item
        {
            get { return second_Item; }
            set { second_Item = value; }
        }

        private string third_Item;
        public string Third_Item
        {
            get { return third_Item; }
            set { third_Item = value; }
        }

        private string forth_Item;
        public string Forth_Item
        {
            get { return forth_Item; }
            set { forth_Item = value; }
        }

        private string fifth_Item;
        public string Fifth_Item
        {
            get { return fifth_Item; }
            set { fifth_Item = value; }
        }

        private bool isEnable;
        public bool IsEnable
        {
            get { return isEnable; }
            set { isEnable = value; }
        }
    }
}
