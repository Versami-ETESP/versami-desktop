using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Entities
{
    class Livro
    {
        private static int bookID;
        private static String titleBook, summaryBook;
        private byte[] cover;
        private Genero genre;
        private Autor autor;

        public int getBookID()
        {
            return bookID;
        }

        public void setBookID(int ID)
        {
            bookID = ID;
        }

        public String getTitle()
        {
            return titleBook;
        }

        public void setTitle(String title)
        {
            titleBook = title;
        }

        public String getSummary()
        {
            return summaryBook;
        }

        public void setSummary(String summary)
        {
            summaryBook = summary;
        }

        public byte[] getCover()
        {
            return cover;
        }

        public void setCover(byte[] cover)
        {
            this.cover = cover;
        }

        public Genero getGenre()
        {
            return genre;
        }

        public void setGenre(Genero genre)
        {
            this.genre = genre;
        }

        public Autor getAutor()
        {
            return autor;
        }

        public void setAutor(Autor autor)
        {
            this.autor = autor;
        }
    }
}
