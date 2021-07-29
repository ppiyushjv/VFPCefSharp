using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFPCefSharp
{

    [Guid("09A74F29-AB1B-479B-B6C5-030E13396AA8")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("VFPCefSharpUserControl")]
    [ComVisible(true)]
    public partial class VFPCefSharpUserControl : UserControl
    {
        public CefSharp.WinForms.ChromiumWebBrowser chromiumWeb;
        public VFPCefSharpUserControl()
        {
            InitializeComponent();
        }

        public void LoadBrowser(string url)
        {
            this.SuspendLayout();
            chromiumWeb = new CefSharp.WinForms.ChromiumWebBrowser(url);
            chromiumWeb.Dock = DockStyle.Fill;
            this.Controls.Add(chromiumWeb);
            this.ResumeLayout();
        }

    }
}
