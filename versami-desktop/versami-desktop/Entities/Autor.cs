using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Autor
    {

        private static int autorID;
        private static String nameAutor, descriptionAutor;

        public int getAutorID()
        {
            return autorID;
        }

        public void setAutorID(int ID)
        {
            autorID = ID;
        }

        public String getName()
        {
            return nameAutor;
        }

        public void setName(String name)
        {
            nameAutor = name;
        }

        public String getDescription()
        {
            return descriptionAutor;
        }

        public void setDescription(String description)
        {
            descriptionAutor = description;
        }

    }
}
