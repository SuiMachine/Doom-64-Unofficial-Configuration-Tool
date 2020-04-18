using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool.CustomControls.BindEditor
{
    public partial class BindAdd : Form
    {
        public KeyMouseWrapper returnedKey = new KeyMouseWrapper();

        public BindAdd()
        {
            InitializeComponent();
            this.Select();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BindEditor_KeyDown(object sender, KeyEventArgs e)
        {
            var keyID = (int)e.KeyCode;
            ReturnKey((D64Keys)keyID);
        }

        private void B_MouseLeft_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.mouse_left);
        }

        private void B_MouseMiddle_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.mouse_middle);
        }

        private void B_MouseRight_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.mouse_right);
        }

        private void B_MouseX1_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.mouse_misc1);
        }

        private void B_MouseX2_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.mouse_misc2);
        }

        private void B_NumpadEnter_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.kp_enter);
        }

        private void ReturnKey(KeyMouseWrapper key)
        {
            this.returnedKey = key;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_GamepadA_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_0);
        }

        private void B_GamepadB_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_1);
        }

        private void B_GamepadY_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_3);
        }

        private void B_GamepadX_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_2);
        }

        private void B_GamepadLeftTrigger_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_15);
        }

        private void B_GamepadRightTrigger_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_16);

        }

        private void B_GamepadLeftAnalogClick_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_7);
        }

        private void B_GamepadRightAnalogClick_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_8);
        }

        private void B_GamepadLeftBumper_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_9);
        }

        private void B_GamepadRightBumper_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_10);
        }

        private void B_GamepadDpadUp_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_11);
        }

        private void B_GamepadDpadDown_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_12);
        }

        private void B_GamepadDpadLeft_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_13);
        }

        private void B_GamepadDpadRight_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_14);
        }

        private void B_GamepadSelect_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_4);
        }

        private void B_GamepadStart_Click(object sender, EventArgs e)
        {
            ReturnKey(GamepadKeys.joy_6);
        }

        private void B_RightShift_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.rshift);
        }

        private void B_RightCtrl_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.rctrl);
        }

        private void B_RightAlt_Click(object sender, EventArgs e)
        {
            ReturnKey(D64Keys.ralt);

        }

        private void B_MWheelUp_Click(object sender, EventArgs e)
        {
            ReturnKey(D64MouseWheel.mouse_wheel_up);
        }

        private void B_MWheelDown_Click(object sender, EventArgs e)
        {
            ReturnKey(D64MouseWheel.mouse_wheel_down);
        }
    }
}
