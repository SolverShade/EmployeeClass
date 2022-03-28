using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.UiResponder
{
    public class StatusDisplay
    {
        private Label _statusLabel; 

        public StatusDisplay(Label statusLabel)
        {
            _statusLabel = statusLabel; 
        }

        public void DisplayMessage(string errorMessage)
        {
            _statusLabel.Text = ("Status: " + errorMessage); 
        }
    }
}
