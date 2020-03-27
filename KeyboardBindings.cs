using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Doom64_Unofficial_Configuration_Tool
{
    public class KeyboardBindings
    {
        #region Actions
        //Menus
        public List<KeyMouseWrapper> MenuSelect = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Menu_back = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Menu_activate = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Menu_Delete = new List<KeyMouseWrapper> { };

        public List<KeyMouseWrapper> MenuLeft = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> MenuRight = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> MenuUp = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> MenuDown = new List<KeyMouseWrapper> { };

        //Weapon keys
        public List<KeyMouseWrapper> Weapon1 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon2 = new List<KeyMouseWrapper> {  };
        public List<KeyMouseWrapper> Weapon3 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon4 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon5 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon6 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon7 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Weapon8 = new List<KeyMouseWrapper> {};
        public List<KeyMouseWrapper> Weapon9 = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> NextWeapon = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> PreviousWeapon = new List<KeyMouseWrapper> {  };

        //Action
        public List<KeyMouseWrapper> Attack = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Use = new List<KeyMouseWrapper> { };

        //Movement
        public List<KeyMouseWrapper> StrafeLeft = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> StrafeRight = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Forward = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Backward = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> Speed = new List<KeyMouseWrapper> {  };
        public List<KeyMouseWrapper> Autorun = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> TurnLeft = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> TurnRight = new List<KeyMouseWrapper> { };

        //Map
        public List<KeyMouseWrapper> Automap = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> MapZoomIn = new List<KeyMouseWrapper> {};
        public List<KeyMouseWrapper> MapZoomOut = new List<KeyMouseWrapper> { };

        //QuickSave/Load and Screenshots
        public List<KeyMouseWrapper> Screenshot = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> QuickSave = new List<KeyMouseWrapper> { };
        public List<KeyMouseWrapper> QuickLoad = new List<KeyMouseWrapper> { };

        //Jump command (not like it's present, but maybe one day)
        public List<KeyMouseWrapper> Jump = new List<KeyMouseWrapper> { };

        public List<string> CustomBinds = new List<string>();
        #endregion

        #region Preconfigured
        public void SetPreconfiguredQWERTY()
        {
            //Menus
            MenuSelect = new List<KeyMouseWrapper> { D64Keys.enter, D64Keys.mouse_left, GamepadKeys.joy_0 };
            Menu_back = new List<KeyMouseWrapper> { GamepadKeys.joy_1 };
            Menu_activate = new List<KeyMouseWrapper> { D64Keys.Escape, GamepadKeys.joy_6 };
            Menu_Delete = new List<KeyMouseWrapper> { D64Keys.Delete, GamepadKeys.joy_2 };
            MenuLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            MenuRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };
            MenuUp = new List<KeyMouseWrapper> { D64Keys.Up, GamepadKeys.joy_11 };
            MenuDown = new List<KeyMouseWrapper> { D64Keys.Down, GamepadKeys.joy_12 };

            //Weapon keys
            Weapon1 = new List<KeyMouseWrapper> { D64Keys.D1 };
            Weapon2 = new List<KeyMouseWrapper> { D64Keys.D2 };
            Weapon3 = new List<KeyMouseWrapper> { D64Keys.D3 };
            Weapon4 = new List<KeyMouseWrapper> { };
            Weapon5 = new List<KeyMouseWrapper> { D64Keys.D4 };
            Weapon6 = new List<KeyMouseWrapper> { D64Keys.D5 };
            Weapon7 = new List<KeyMouseWrapper> { D64Keys.D6 };
            Weapon8 = new List<KeyMouseWrapper> { D64Keys.D7 };
            Weapon9 = new List<KeyMouseWrapper> { D64Keys.D8 };
            NextWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_up, GamepadKeys.joy_10 };
            PreviousWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_down, GamepadKeys.joy_9 };

            //Action
            Attack = new List<KeyMouseWrapper> { D64Keys.mouse_left, GamepadKeys.joy_16 };

            Use = new List<KeyMouseWrapper> { D64Keys.E, GamepadKeys.joy_0, GamepadKeys.joy_15 };

            //Movement
            StrafeLeft = new List<KeyMouseWrapper> { D64Keys.A };
            StrafeRight = new List<KeyMouseWrapper> { D64Keys.D };
            Forward = new List<KeyMouseWrapper> { D64Keys.W };
            Backward = new List<KeyMouseWrapper> { D64Keys.S };
            Speed = new List<KeyMouseWrapper> { D64Keys.Space, GamepadKeys.joy_15 };
            Autorun = new List<KeyMouseWrapper> { D64Keys.Caps_lock, GamepadKeys.joy_7 };
            TurnLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            TurnRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };

            //Map
            Automap = new List<KeyMouseWrapper> { D64Keys.tab, GamepadKeys.joy_4 };
            MapZoomIn = new List<KeyMouseWrapper> { D64Keys.R, GamepadKeys.joy_11 };
            MapZoomOut = new List<KeyMouseWrapper> { D64Keys.Q, GamepadKeys.joy_12 };

            //QuickSave/Load and Screenshots
            Screenshot = new List<KeyMouseWrapper> { };
            QuickSave = new List<KeyMouseWrapper> { D64Keys.F5, D64Keys.F6 };
            QuickLoad = new List<KeyMouseWrapper> { D64Keys.F9 };

            //Jump command (not like it's present, but maybe one day)
            Jump = new List<KeyMouseWrapper> { D64Keys.mouse_right };
        }

        public void SetPreconfiguredQWERTY_ESDF()
        {
            //Menus
            MenuSelect = new List<KeyMouseWrapper> { D64Keys.enter, D64Keys.mouse_left, GamepadKeys.joy_0 };
            Menu_back = new List<KeyMouseWrapper> { GamepadKeys.joy_1 };
            Menu_activate = new List<KeyMouseWrapper> { D64Keys.Escape, GamepadKeys.joy_6 };
            Menu_Delete = new List<KeyMouseWrapper> { D64Keys.Delete, GamepadKeys.joy_2 };

            MenuLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            MenuRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };
            MenuUp = new List<KeyMouseWrapper> { D64Keys.Up, GamepadKeys.joy_11 };
            MenuDown = new List<KeyMouseWrapper> { D64Keys.Down, GamepadKeys.joy_12 };

            //Weapon keys
            Weapon1 = new List<KeyMouseWrapper> { D64Keys.D1 };
            Weapon2 = new List<KeyMouseWrapper> { D64Keys.D2 };
            Weapon3 = new List<KeyMouseWrapper> { D64Keys.D3 };
            Weapon4 = new List<KeyMouseWrapper> { };
            Weapon5 = new List<KeyMouseWrapper> { D64Keys.D4 };
            Weapon6 = new List<KeyMouseWrapper> { D64Keys.D5 };
            Weapon7 = new List<KeyMouseWrapper> { D64Keys.D6 };
            Weapon8 = new List<KeyMouseWrapper> { D64Keys.D7 };
            Weapon9 = new List<KeyMouseWrapper> { D64Keys.D8 };
            NextWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_up, GamepadKeys.joy_10 };
            PreviousWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_down, GamepadKeys.joy_9 };

            //Action
            Attack = new List<KeyMouseWrapper> { D64Keys.mouse_left, GamepadKeys.joy_16 };

            Use = new List<KeyMouseWrapper> { D64Keys.R, GamepadKeys.joy_0, GamepadKeys.joy_15 };

            //Movement
            StrafeLeft = new List<KeyMouseWrapper> { D64Keys.S };
            StrafeRight = new List<KeyMouseWrapper> { D64Keys.F };
            Forward = new List<KeyMouseWrapper> { D64Keys.E };
            Backward = new List<KeyMouseWrapper> { D64Keys.D };
            Speed = new List<KeyMouseWrapper> { D64Keys.Space, GamepadKeys.joy_15 };
            Autorun = new List<KeyMouseWrapper> { D64Keys.Caps_lock, GamepadKeys.joy_7 };
            TurnLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            TurnRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };

            //Map
            Automap = new List<KeyMouseWrapper> { D64Keys.tab, GamepadKeys.joy_4 };
            MapZoomIn = new List<KeyMouseWrapper> { D64Keys.T, GamepadKeys.joy_11 };
            MapZoomOut = new List<KeyMouseWrapper> { D64Keys.W, GamepadKeys.joy_12 };

            //QuickSave/Load and Screenshots
            Screenshot = new List<KeyMouseWrapper> { };
            QuickSave = new List<KeyMouseWrapper> { D64Keys.F5, D64Keys.F6 };
            QuickLoad = new List<KeyMouseWrapper> { D64Keys.F9 };

            //Jump command (not like it's present, but maybe one day)
            Jump = new List<KeyMouseWrapper> { D64Keys.mouse_right };
        }

        public void SetPreconfiguredAZERTY()
        {
            //Menus
            MenuSelect = new List<KeyMouseWrapper> { D64Keys.enter, D64Keys.mouse_left, GamepadKeys.joy_0 };
            Menu_back = new List<KeyMouseWrapper> { GamepadKeys.joy_1 };
            Menu_activate = new List<KeyMouseWrapper> { D64Keys.Escape, GamepadKeys.joy_6 };
            Menu_Delete = new List<KeyMouseWrapper> { D64Keys.Delete, GamepadKeys.joy_2 };

            MenuLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            MenuRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };
            MenuUp = new List<KeyMouseWrapper> { D64Keys.Up, GamepadKeys.joy_11 };
            MenuDown = new List<KeyMouseWrapper> { D64Keys.Down, GamepadKeys.joy_12 };

            //Weapon keys
            Weapon1 = new List<KeyMouseWrapper> { D64Keys.D1 };
            Weapon2 = new List<KeyMouseWrapper> { D64Keys.D2 };
            Weapon3 = new List<KeyMouseWrapper> { D64Keys.D3 };
            Weapon4 = new List<KeyMouseWrapper> { };
            Weapon5 = new List<KeyMouseWrapper> { D64Keys.D4 };
            Weapon6 = new List<KeyMouseWrapper> { D64Keys.D5 };
            Weapon7 = new List<KeyMouseWrapper> { D64Keys.D6 };
            Weapon8 = new List<KeyMouseWrapper> { D64Keys.D7 };
            Weapon9 = new List<KeyMouseWrapper> { D64Keys.D8 };
            NextWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_up, GamepadKeys.joy_10 };
            PreviousWeapon = new List<KeyMouseWrapper> { D64MouseWheel.mouse_wheel_down, GamepadKeys.joy_9 };

            //Action
            Attack = new List<KeyMouseWrapper> { D64Keys.mouse_left, GamepadKeys.joy_16 };

            Use = new List<KeyMouseWrapper> { D64Keys.E, GamepadKeys.joy_0, GamepadKeys.joy_15 };

            //Movement
            StrafeLeft = new List<KeyMouseWrapper> { D64Keys.Q };
            StrafeRight = new List<KeyMouseWrapper> { D64Keys.D };
            Forward = new List<KeyMouseWrapper> { D64Keys.Z };
            Backward = new List<KeyMouseWrapper> { D64Keys.S };
            Speed = new List<KeyMouseWrapper> { D64Keys.Space, GamepadKeys.joy_15 };
            Autorun = new List<KeyMouseWrapper> { D64Keys.Caps_lock, GamepadKeys.joy_7 };
            TurnLeft = new List<KeyMouseWrapper> { D64Keys.Left, GamepadKeys.joy_13 };
            TurnRight = new List<KeyMouseWrapper> { D64Keys.Right, GamepadKeys.joy_14 };

            //Map
            Automap = new List<KeyMouseWrapper> { D64Keys.tab, GamepadKeys.joy_4 };
            MapZoomIn = new List<KeyMouseWrapper> { D64Keys.R, GamepadKeys.joy_11 };
            MapZoomOut = new List<KeyMouseWrapper> { D64Keys.A, GamepadKeys.joy_12 };

            //QuickSave/Load and Screenshots
            Screenshot = new List<KeyMouseWrapper> { };
            QuickSave = new List<KeyMouseWrapper> { D64Keys.F5, D64Keys.F6 };
            QuickLoad = new List<KeyMouseWrapper> { D64Keys.F9 };

            //Jump command (not like it's present, but maybe one day)
            Jump = new List<KeyMouseWrapper> { D64Keys.mouse_right };
        }
        #endregion

        internal void TranslateFromBind(string line)
        {
            Regex regx = new Regex("bind( +)(.+?)( +)\"(.+?)\"", RegexOptions.IgnoreCase);

            if (regx.IsMatch(line))
            {
                var matches = regx.Matches(line);

                var buttonName = matches[0].Groups[2].Value.ToLower();
                var action = matches[0].Groups[4].Value;

                KeyMouseWrapper button = KeyMouseWrapper.Parse(buttonName);
                if (button != null)
                {
                    switch (action)
                    {
                        case "automap":
                            Automap.Add(button);
                            return;
                        case "*menu_select":
                            MenuSelect.Add(button);
                            return;
                        case "menu_activate":
                            Menu_activate.Add(button);
                            return;
                        case "menu_back":
                            Menu_back.Add(button);
                            return;
                        case "menu_delete":
                            Menu_Delete.Add(button);
                            return;
                        case "menu_right":
                            MenuRight.Add(button);
                            return;
                        case "menu_left":
                            MenuLeft.Add(button);
                            return;
                        case "menu_down":
                            MenuDown.Add(button);
                            return;
                        case "menu_up":
                            MenuUp.Add(button);
                            return;
                        case "speed":
                            Speed.Add(button);
                            return;
                        case "weapon 1":
                            Weapon1.Add(button);
                            return;
                        case "weapon 2":
                            Weapon2.Add(button);
                            return;
                        case "weapon 3":
                            Weapon3.Add(button);
                            return;
                        case "weapon 4":
                            Weapon4.Add(button);
                            return;
                        case "weapon 5":
                            Weapon5.Add(button);
                            return;
                        case "weapon 6":
                            Weapon6.Add(button);
                            return;
                        case "weapon 7":
                            Weapon7.Add(button);
                            return;
                        case "weapon 8":
                            Weapon8.Add(button);
                            return;
                        case "weapon 9":
                            Weapon9.Add(button);
                            return;
                        case "strafe_left":
                            StrafeLeft.Add(button);
                            return;
                        case "strafe_right":
                            StrafeRight.Add(button);
                            return;
                        case "backward":
                            Backward.Add(button);
                            return;
                        case "forward":
                            Forward.Add(button);
                            return;
                        case "use":
                            Use.Add(button);
                            return;
                        case "mapzoomout":
                            MapZoomOut.Add(button);
                            return;
                        case "mapzoomin":
                            MapZoomIn.Add(button);
                            return;
                        case "+autorun":
                            Autorun.Add(button);
                            return;
                        case "screenshot":
                            Screenshot.Add(button);
                            return;
                        case "quicksave":
                            QuickSave.Add(button);
                            return;
                        case "quickload":
                            QuickLoad.Add(button);
                            return;
                        case "right":
                            TurnRight.Add(button);
                            return;
                        case "left":
                            TurnLeft.Add(button);
                            return;
                        case "attack":
                            Attack.Add(button);
                            return;
                        case "jump":    //Dunno why, since that game obviously doesn't support jump
                            Jump.Add(button);
                            return;
                        case "+nextweap":
                            NextWeapon.Add(button);
                            return;
                        case "+prevweap":
                            PreviousWeapon.Add(button);
                            return;
                        default:
                            CustomBinds.Add(line);
                            return;
                    }
                }



            }
        }

        internal string[] TranslateToBind()
        {
            List<string> outPutLines = new List<string>();
            string bindFormat = "bind {0} \"{1}\"";

            outPutLines.AddFormatted(bindFormat, "automap", Automap);
            outPutLines.AddFormatted(bindFormat, "*menu_select", MenuSelect);
            outPutLines.AddFormatted(bindFormat, "menu_activate", Menu_activate);
            outPutLines.AddFormatted(bindFormat, "menu_back", Menu_back);

            outPutLines.AddFormatted(bindFormat, "menu_delete", Menu_Delete);
            outPutLines.AddFormatted(bindFormat, "menu_right", MenuRight);
            outPutLines.AddFormatted(bindFormat, "menu_left", MenuLeft);
            outPutLines.AddFormatted(bindFormat, "menu_down", MenuDown);
            outPutLines.AddFormatted(bindFormat, "menu_up", MenuUp);
            outPutLines.AddFormatted(bindFormat, "speed", Speed);

            outPutLines.AddFormatted(bindFormat, "weapon 1", Weapon1);
            outPutLines.AddFormatted(bindFormat, "weapon 2", Weapon2);
            outPutLines.AddFormatted(bindFormat, "weapon 3", Weapon3);
            outPutLines.AddFormatted(bindFormat, "weapon 4", Weapon4);
            outPutLines.AddFormatted(bindFormat, "weapon 5", Weapon5);
            outPutLines.AddFormatted(bindFormat, "weapon 6", Weapon6);
            outPutLines.AddFormatted(bindFormat, "weapon 7", Weapon7);
            outPutLines.AddFormatted(bindFormat, "weapon 8", Weapon8);
            outPutLines.AddFormatted(bindFormat, "weapon 9", Weapon9);

            outPutLines.AddFormatted(bindFormat, "strafe_left", StrafeLeft);
            outPutLines.AddFormatted(bindFormat, "strafe_right", StrafeRight);
            outPutLines.AddFormatted(bindFormat, "backward", Backward);
            outPutLines.AddFormatted(bindFormat, "forward", Forward);

            outPutLines.AddFormatted(bindFormat, "use", Use);
            outPutLines.AddFormatted(bindFormat, "mapzoomout", MapZoomOut);
            outPutLines.AddFormatted(bindFormat, "mapzoomin", MapZoomIn);

            outPutLines.AddFormatted(bindFormat, "+autorun", Autorun);
            outPutLines.AddFormatted(bindFormat, "screenshot", Screenshot);
            outPutLines.AddFormatted(bindFormat, "quicksave", QuickSave);
            outPutLines.AddFormatted(bindFormat, "quickload", QuickLoad);
            outPutLines.AddFormatted(bindFormat, "right", TurnRight);
            outPutLines.AddFormatted(bindFormat, "left", TurnLeft);
            outPutLines.AddFormatted(bindFormat, "attack", Attack);


            outPutLines.AddFormatted(bindFormat, "+nextweap", NextWeapon);
            outPutLines.AddFormatted(bindFormat, "+prevweap", PreviousWeapon);

            outPutLines.AddFormatted(bindFormat, "jump", Jump);

            outPutLines.AddRange(CustomBinds);

            return outPutLines.ToArray();
        }

    }

    public class KeyMouseWrapper
    {
        public D64Keys keyboardKey = D64Keys.None;
        public D64MouseWheel mouseKey = D64MouseWheel.None;
        public GamepadKeys gamepadButton = GamepadKeys.None;

        internal static KeyMouseWrapper Parse(string buttonName)
        {
            if(StringExtensons.d64KeysToNetKeysDictionary.ContainsKey(buttonName))
            {
                return (KeyMouseWrapper)StringExtensons.d64KeysToNetKeysDictionary[buttonName];
            }
            else if (Enum.TryParse(buttonName, true, out D64Keys newK))
            {
                return (KeyMouseWrapper)newK;
            }
            else if (Enum.TryParse(buttonName, true, out D64MouseWheel mouseButton))
            {
                return (KeyMouseWrapper)mouseButton;
            }
            else if (Enum.TryParse(buttonName, true, out GamepadKeys gamepadButton))
            {
                return (KeyMouseWrapper)gamepadButton;
            }
            else
                return null;

        }

        public override string ToString()
        {

            if (keyboardKey != D64Keys.None)
            {
                var firstFound = StringExtensons.d64KeysToNetKeysDictionary.FirstOrDefault(x => x.Value.ToString() == keyboardKey.ToString());
                if (firstFound.Key != null)
                    return firstFound.Key;

                return keyboardKey.ToString();

            }
            else if (mouseKey != D64MouseWheel.None)
                return mouseKey.ToString();
            else
                return gamepadButton.ToString();
        }

        public string ToDescriptionString()
        {
            if (keyboardKey != D64Keys.None)
                return keyboardKey.GetDescription();
            else if (mouseKey != D64MouseWheel.None)
                return mouseKey.GetDescription();
            else
                return gamepadButton.GetDescription();
        }

        #region ImplicitCasts
        public static implicit operator KeyMouseWrapper(D64Keys keyboardKeyV)
        {
            return new KeyMouseWrapper() { keyboardKey = keyboardKeyV };
        }

        public static implicit operator KeyMouseWrapper(D64MouseWheel mouseKeyV)
        {
            return new KeyMouseWrapper() { mouseKey = mouseKeyV };
        }

        public static implicit operator KeyMouseWrapper(GamepadKeys gamepadButtonV)
        {
            return new KeyMouseWrapper() { gamepadButton = gamepadButtonV };
        }
        #endregion
    }
}