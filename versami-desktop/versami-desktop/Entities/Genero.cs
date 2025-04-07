using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Genero
    {
        private static int generoID;
        private static String nameGenero, descriptionGenero;

        public int getGeneroID()
        {
            return generoID;
        }

        public void setGeneroID(int id)
        {
            generoID = id;
        }

        public String getType()
        {
            return nameGenero;
        }

        public void setType(String name)
        {
            nameGenero = name;
        }

        public String getDescription()
        {
            return descriptionGenero;
        }

        public void setDescription(String description)
        {
            descriptionGenero = description;
        }
    }
}
