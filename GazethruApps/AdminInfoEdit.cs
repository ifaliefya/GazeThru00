using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazethruApps
{
    public partial class AdminInfoEdit : Form
    {
        public AdminInfoEdit( string InfoID, string JudulInfo, string IsiInfo, Image img)
        {
            InitializeComponent();
            NoInfo.Text = InfoID;
            textBoxJudul.Text = JudulInfo;
            String[] descs = { IsiInfo };
            foreach (String desc in descs)
            {
                textBoxIsi.Text = desc;
                Int32 offset = textBoxIsi.Rtf.IndexOf(@"\f0\fs17") + 8;
                Int32 len = textBoxIsi.Rtf.LastIndexOf(@"\par") - offset;
                Console.WriteLine("{0,-15} : {1}", desc, textBoxIsi.Rtf.Substring(offset, len).Trim());
            }
            pictureBox1.Image = img; 
        }

    }
}
