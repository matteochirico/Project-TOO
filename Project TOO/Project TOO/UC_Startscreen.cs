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
        
        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Proceed();
            }
        }

        private void Procced_Click(object sender, EventArgs e)
        {
            Proceed();
        }

        private void Proceed()
        {
            var text = Textbox.Text;
            
            if (!string.IsNullOrWhiteSpace(text))
            {
                string formattedName = string.Empty;
                
                if (!text.Contains(' '))
                {
                    var firstLetter = text.Substring(0, 1).ToUpper();
                    var restName = text.Substring(1, text.Length - 1).ToLower();
                    formattedName = firstLetter + restName;
                }
                else if (text.Contains(' '))
                {
                    var space = text.IndexOf(' ');
                    var firstLetterSecond = string.Empty;
                    var restOfSecondName = string.Empty;

                    var firstLetter = text.Substring(0, 1).ToUpper();
                    var restOfFirstName = text.Substring(1, space).ToLower();
                    
                    try
                    {
                        firstLetterSecond = text.Substring(space + 1, 1).ToUpper();
                        restOfSecondName = text.Substring(space + 2).ToLower();
                    }
                    catch { ShowErrorText(false); }
                    
                    formattedName = (firstLetter + restOfFirstName) + (firstLetterSecond + restOfSecondName);
                }

                ProjectController.SetDisplayName(formattedName);
            }
            else
            {
                if (Label_ErrorText.Visible != true)
                {
                    ShowErrorText(true);
                }
                return;
            }

            MainForm.SwitchPanelUC(MainForm.UserControl.Mainscreen);
        }

        private async void ShowErrorText(bool error)
        {
            if (error)
            {
                Label_ErrorText.Visible = true;
            }
            else
            {
                Label_ErrorText.Text = "Kontroller mellomrom i navnet og fortsett.";
                Label_ErrorText.Visible = true;
            }

            await Task.Delay(TimeSpan.FromSeconds(1));
            Label_ErrorText.Visible = false;
        }
    }
}
