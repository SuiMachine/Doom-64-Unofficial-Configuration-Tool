using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.CustomControls
{
    public partial class KeyControlForm : UserControl
    {
        public string ActionName { get; set; }
        public List<KeyMouseWrapper> keyBindsForAction { get; set; }

        public KeyControlForm()
        {
            InitializeComponent();
        }

        private void KeyControlForm_Load(object sender, EventArgs e)
        {
            this.labelActionName.DataBindings.Add("Text", this, "ActionName", false, DataSourceUpdateMode.OnPropertyChanged);
            
            RefreshKeys();
        }

        public void RefreshKeys()
        {
            if(keyBindsForAction != null)
            {
                string outputText = "";
                foreach (var key in keyBindsForAction)
                {
                    if (key.keyboardKey != D64Keys.None)
                    {
                        outputText += key.keyboardKey.GetDescription() + "; ";
                    }
                    else if (key.mouseKey != D64MouseWheel.None)
                    {
                        outputText += key.mouseKey.GetDescription() + "; ";
                    }
                    else if (key.gamepadButton != GamepadKeys.None)
                    {
                        outputText += key.gamepadButton.GetDescription() + "; ";
                    }
                }
                this.TB_MenuActivate.Text = outputText;
            }
        }

        private void B_AddKey_Click(object sender, EventArgs e)
        {
            var bindAddForm = new BindEditor.BindAdd();
            var result = bindAddForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(!this.keyBindsForAction.Contains(bindAddForm.returnedKey))
                    this.keyBindsForAction.Add(bindAddForm.returnedKey);
            }
            this.RefreshKeys();
        }

        private void B_EditKeys_Click(object sender, EventArgs e)
        {
            var bindEdit = new BindEditor.BindEditor(keyBindsForAction.ToList());
            var result = bindEdit.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.keyBindsForAction = bindEdit.keysBound;
            }
            this.RefreshKeys();
        }

        private void B_EditKeys_Paint(object sender, PaintEventArgs e)
        {
            RefreshKeys();
        }
    }
}
