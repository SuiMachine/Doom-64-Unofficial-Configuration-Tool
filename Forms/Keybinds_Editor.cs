using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doom64_Unofficial_Configuration_Tool.CustomControls;

namespace Doom64_Unofficial_Configuration_Tool.Forms
{
    public partial class Keybinds_Editor : Form
    {
        public KeyboardBindings keyBinds { get; set; }

        public Keybinds_Editor(KeyboardBindings keyBinds)
        {
            this.keyBinds = keyBinds;
            InitializeComponent(); 
        }

        private void Keybinds_Editor_Load(object sender, EventArgs e)
        {
            //Menu things
            this.UF_MenuSelect.keyBindsForAction = keyBinds.MenuSelect;
            this.UF_MenuActivate.keyBindsForAction = keyBinds.Menu_activate;
            this.UF_MenuBack.keyBindsForAction = keyBinds.Menu_back;
            this.UF_MenuDelete.keyBindsForAction = keyBinds.Menu_Delete;
            this.UF_MenuLeft.keyBindsForAction = keyBinds.MenuLeft;
            this.UF_MenuRight.keyBindsForAction = keyBinds.MenuRight;
            this.UF_MenuDown.keyBindsForAction = keyBinds.MenuDown;
            this.UF_MenuUp.keyBindsForAction = keyBinds.MenuUp;

            //Movement
            this.UF_MovementForward.keyBindsForAction = keyBinds.Forward;
            this.UF_MovementBackward.keyBindsForAction = keyBinds.Backward;
            this.UF_MovementStrafeLeft.keyBindsForAction = keyBinds.StrafeLeft;
            this.UF_MovementStrafeRight.keyBindsForAction = keyBinds.StrafeRight;
            this.UF_MovementTurnLeft.keyBindsForAction = keyBinds.TurnLeft;
            this.UF_MovementTurnRight.keyBindsForAction = keyBinds.TurnRight;
            this.UF_MovementRun.keyBindsForAction = keyBinds.Speed;
            this.UF_MovementToggleRun.keyBindsForAction = keyBinds.Autorun;

            //Weapons
            this.UF_Weapon1.keyBindsForAction = keyBinds.Weapon1;
            this.UF_Weapon2.keyBindsForAction = keyBinds.Weapon2;
            this.UF_Weapon3.keyBindsForAction = keyBinds.Weapon3;
            this.UF_Weapon4.keyBindsForAction = keyBinds.Weapon4;
            this.UF_Weapon5.keyBindsForAction = keyBinds.Weapon5;
            this.UF_Weapon6.keyBindsForAction = keyBinds.Weapon6;
            this.UF_Weapon7.keyBindsForAction = keyBinds.Weapon7;
            this.UF_Weapon8.keyBindsForAction = keyBinds.Weapon8;
            this.UF_Weapon9.keyBindsForAction = keyBinds.Weapon9;
            this.UF_OtherNextWeapon.keyBindsForAction = keyBinds.NextWeapon;
            this.UF_OtherPreviousWeapon.keyBindsForAction = keyBinds.PreviousWeapon;

            //Action
            this.UF_ActionAttack.keyBindsForAction = keyBinds.Attack;
            this.UF_ActionUse.keyBindsForAction = keyBinds.Use;

            //Map
            this.UF_MapShowHide.keyBindsForAction = keyBinds.Automap;
            this.UF_MapZoomIn.keyBindsForAction = keyBinds.MapZoomIn;
            this.UF_MapZoomOut.keyBindsForAction = keyBinds.MapZoomOut;

            //Other
            this.UF_OtherScreenshot.keyBindsForAction = keyBinds.Screenshot;
            this.UF_OtherQuickSave.keyBindsForAction = keyBinds.QuickSave;
            this.UF_OtherQuickLoad.keyBindsForAction = keyBinds.QuickLoad;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            //Menu things
            keyBinds.MenuSelect = UF_MenuSelect.keyBindsForAction;
            keyBinds.Menu_activate = UF_MenuActivate.keyBindsForAction;
            keyBinds.Menu_back = UF_MenuBack.keyBindsForAction;
            keyBinds.Menu_Delete = UF_MenuDelete.keyBindsForAction;
            keyBinds.MenuLeft = UF_MenuLeft.keyBindsForAction;
            keyBinds.MenuRight = UF_MenuRight.keyBindsForAction;
            keyBinds.MenuDown = UF_MenuDown.keyBindsForAction;
            keyBinds.MenuUp = UF_MenuUp.keyBindsForAction;

            //Movement
            keyBinds.Forward = UF_MovementForward.keyBindsForAction;
            keyBinds.Backward = UF_MovementBackward.keyBindsForAction;
            keyBinds.StrafeLeft = UF_MovementStrafeLeft.keyBindsForAction;
            keyBinds.StrafeRight = UF_MovementStrafeRight.keyBindsForAction;
            keyBinds.TurnLeft= UF_MovementTurnLeft.keyBindsForAction;
            keyBinds.TurnRight = UF_MovementTurnRight.keyBindsForAction;
            keyBinds.Speed = UF_MovementRun.keyBindsForAction;
            keyBinds.Autorun = UF_MovementToggleRun.keyBindsForAction;

            //Weapons
            keyBinds.Weapon1 = UF_Weapon1.keyBindsForAction;
            keyBinds.Weapon2 = UF_Weapon2.keyBindsForAction;
            keyBinds.Weapon3 = UF_Weapon3.keyBindsForAction;
            keyBinds.Weapon4 = UF_Weapon4.keyBindsForAction;
            keyBinds.Weapon5 = UF_Weapon5.keyBindsForAction;
            keyBinds.Weapon6 = UF_Weapon6.keyBindsForAction;
            keyBinds.Weapon7 = UF_Weapon7.keyBindsForAction;
            keyBinds.Weapon8 = UF_Weapon8.keyBindsForAction;
            keyBinds.Weapon9 = UF_Weapon9.keyBindsForAction;
            keyBinds.NextWeapon = UF_OtherNextWeapon.keyBindsForAction;
            keyBinds.PreviousWeapon = UF_OtherPreviousWeapon.keyBindsForAction;

            //Action
            keyBinds.Attack = UF_ActionAttack.keyBindsForAction;
            keyBinds.Use = UF_ActionUse.keyBindsForAction;

            //Map
            keyBinds.Automap = UF_MapShowHide.keyBindsForAction;
            keyBinds.MapZoomIn = UF_MapZoomIn.keyBindsForAction;
            keyBinds.MapZoomOut = UF_MapZoomOut.keyBindsForAction;

            //Other
            keyBinds.Screenshot = UF_OtherScreenshot.keyBindsForAction;
            keyBinds.QuickSave = UF_OtherQuickSave.keyBindsForAction;
            keyBinds.QuickLoad = UF_OtherQuickLoad.keyBindsForAction;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
