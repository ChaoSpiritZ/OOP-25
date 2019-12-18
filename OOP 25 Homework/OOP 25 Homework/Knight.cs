using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    public class Knight : IComparable<Knight>, IGetName
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return Name;
                if (fieldName == "BirthTown")
                    return BirthTown;
                if (fieldName == "Title")
                    return Title;
                return "UNKNOWN FIELD NAME";
            }

            set
            {
                if (fieldName == "Name")
                    Name = value; ;
                if (fieldName == "BirthTown")
                    BirthTown = value;
                if (fieldName == "Title")
                    Title = value;
            }
        }

        public string GetName()
        {
            return Name;
        }

        public int CompareTo(Knight other)
        {
            if(this.Name == other.Name)
            {
                return 0;
            }
            if (this.Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return $"Knight --- Name: {Name}, Birth Town: {BirthTown}, Title: {Title}";
        }
    }
}
