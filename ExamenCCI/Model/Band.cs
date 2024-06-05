using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCCI.Model
{
    public class Band
    {
        public string Country {  get; set; }
        public  DateTime Date{  get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Photo {  get; set; }
        public string Stage { get; set; }

        public Band(string _country, DateTime _date, string _description, string _genre, int _id, string _name, Image _photo, string _stage) 
        {   
            Country = _country;
            Date = _date;
            Description = _description;
            Genre = _genre;
            Id = _id;
            Name = _name;
            Photo = _photo;
            Stage = _stage;
         
        }

    }
}
