using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DO
{
    [Serializable]
    public class Expediente
    {
        private string id;
        private List<Image> images;

        public List<Image> Images
        {
            get { return (images!=null) ? images : images = new List<Image>(); }
            set { images = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
