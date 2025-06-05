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
