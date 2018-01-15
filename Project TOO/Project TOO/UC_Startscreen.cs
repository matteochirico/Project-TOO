using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TOO
{
    public partial class UC_Startscreen : UserControl
    {
        public UC_Startscreen()
        {
            InitializeComponent();
        }
        
        private void Textbox_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
        }

        private void Procced_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Proceed();
            }
        }

        private void Proceed()
        {
            var text = Textbox.Text;
            
            if (!string.IsNullOrWhiteSpace(text))
            {
                string formattedName = string.Empty;

                if (!text.Contains(" "))
                {
                    var firstLetter = text.Substring(0, 1).ToUpper();
                    var restName = text.Substring(1, text.Length - 1).ToLower();
                    formattedName = firstLetter + restName;
                }
                else
                {
                    var space = text.IndexOf(" ");

                    var firstLetter = text.Substring(0, 1).ToUpper();
                    var firstNameRest = text.Substring(1, space - 1).ToLower();

                    var firstLetterSecondName = text.Substring(space, 1).ToUpper();
                    string restOfSecondName; 

                    formattedName = (firstLetter + firstNameRest) + firstLetterSecondName + restOfSecondName;
                }

                ProjectController.SetDisplayName(formattedName);
            }
            else
            {
                ShowErrorText();
                return;
            }

            MainForm.SwitchPanelUC(MainForm.UserControl.Mainscreen);
        }

        private async void ShowErrorText()
        {
            Label_ErrorText.Visible = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            Label_ErrorText.Visible = false;
        }
    }
}
