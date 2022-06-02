using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2Alogithms.Model
{
    class Menu
    {
        private int id;
        private string title;
        private int parent_id;
         
        public Menu()
        {

        }

        public Menu(int id, string title, int parent_id)
        {
            this.id = id;
            this.title = title;
            this.parent_id = parent_id;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Parent_id { get => parent_id; set => parent_id = value; }
    }
}
