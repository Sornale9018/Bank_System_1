using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoIdGenerator
{
    public class Address
    {

        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

       /* public Address(int houseNo, int roadNo, string city)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
        }*/
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return roadNo; }
        }

        public string HouseNo
        {
            set {  this.houseNo= value; }
            get { return houseNo; }
        }

        public string City
        {
            set { this.city = value; }
            get { return city; }
        }


        public string Country
        {
            set { this.country = value; }
            get { return country; }
        }
        public string GetAddress()
        {
            Console.WriteLine("Address---->\n");
             string x = "Road No="+roadNo+","+"House No="+houseNo+","+"City="+city+","+"Country="+country;
            Console.WriteLine(x);
            return x;
            
            
            

        }


























        }
    }
