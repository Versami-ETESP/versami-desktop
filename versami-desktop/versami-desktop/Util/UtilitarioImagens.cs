using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Util
{
    class UtilitarioImagens
    {
        public static byte[] ConverteImagemParaByteArray(Image img)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    img.Save(mStream, img.RawFormat);
                    return mStream.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Image ConverteByteParaImagem(byte[] arquivo)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream(arquivo))
                {
                    return Image.FromStream(mStream);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
