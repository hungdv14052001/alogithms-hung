using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2Array.Model
{
    class Category
    {
        private int id;
        private string name;

        public Category()
        {
            
        }

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
