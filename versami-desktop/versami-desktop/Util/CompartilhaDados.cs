using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Entities;

namespace versami_desktop.Util
{
    class CompartilhaDados
    {
        private static Post publicacao;
        private static BlogPost blog;

        public static BlogPost getBlog()
        {
            return blog;
        }

        public static void setBlog(BlogPost b)
        {
            blog = b;
        }

        public static Post getPublicacao()
        {
            return publicacao;
        }

        public static void setPublicacao(Post post)
        {
            publicacao = post;
        }

        public static void limparPost()
        {
            publicacao = null;
        }
    }
}
