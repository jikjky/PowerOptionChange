using Microsoft.Win32;
using Power.Hook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power
{
    public partial class PowerForm : Form
    {
        enum State
        {
            Other,
            HighPerformance,
            PowerSaver,
        }
        private State state;
        private string HighPerfomanceGuid;
        private string PowerSaverGuid;

        public KeyboardHook keyboardHook = new KeyboardHook();

        static RegistryKey highRegistrykey = Registry.CurrentUser.CreateSubKey("Power Setting").CreateSubKey("High Perfomance");
        static RegistryKey saveRegistrykey = Registry.CurrentUser.CreateSubKey("Power Setting").CreateSubKey("Power Saver");

        RegistryKeyConfig highConfig = new RegistryKeyConfig(highRegistrykey);
        RegistryKeyConfig saveConfig = new RegistryKeyConfig(saveRegistrykey);

        public class RegistryKeyConfig
        {
            RegistryKey myRegistryKey;

            public RegistryKeyConfig(RegistryKey registryKey)
            {
                myRegistryKey = registryKey;
            }

            public bool bCtrl
            {
                get
                {
                    return Convert.ToBoolean(myRegistryKey.GetValue("Ctrl"));
                }
                set
                {
                    myRegistryKey.SetValue("Ctrl", value);
                }
            }
            public bool bAlt
            {
                get
                {
                    return Convert.ToBoolean(myRegistryKey.GetValue("Alt"));
                }
                set
                {
                    myRegistryKey.SetValue("Alt", value);
                }
            }
            public bool bShift
            {
                get
                {
                    return Convert.ToBoolean(myRegistryKey.GetValue("Shift"));
                }
                set
                {
                    myRegistryKey.SetValue("Shift", value);
                }
            }
            public Keys key
            {
                get
                {
                    try
                    {
                        var returnValue = (Keys)Enum.Parse(typeof(Keys), Convert.ToString(myRegistryKey.GetValue("Key")));
                        return returnValue;
                    }
                    catch
                    {
                        return Keys.None;
                    }
                }
                set
                {
                    myRegistryKey.SetValue("Key", value.ToString());
                }
            }


        }

        public PowerForm()
        {
            InitializeComponent();
            keyboardHook.KeyDown += new KeyEventHandler(keyboardHook_KeyDown);
            keyboardHook.Start();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            SetWatch();
            
        }

        bool currentControl;
        bool currentAlt;
        bool currentShift;
        Keys currentKey;
        void keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            currentControl = e.Control;
            currentAlt = e.Alt;
            currentShift = e.Shift;
            currentKey = e.KeyCode;

            if (highConfig.bCtrl == e.Control && highConfig.bAlt == e.Alt && highConfig.bShift == e.Shift && highConfig.key == e.KeyCode)
            {
                SetHighPerfomance();
            }
            if (saveConfig.bCtrl == e.Control && saveConfig.bAlt == e.Alt && saveConfig.bShift == e.Shift && saveConfig.key == e.KeyCode)
            {
                SetPowerSaver();
            }
        }

        private void SetWatch()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            Process process = new Process();

            processInfo.FileName = "cmd.exe";
            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            process.StartInfo = processInfo;
            new Thread(() =>
            {
                while (true)
                {
                    process.Start();
                    process.StandardInput.Write(@"powercfg /L" + Environment.NewLine);
                    process.StandardInput.Close();
                    string ouputString = process.StandardOutput.ReadToEnd();
                    foreach (var line in ouputString.Split('\n'))
                    {
                        if (line.IndexOf("고성능") != -1 || line.IndexOf("High performance") != -1)
                        {
                            string name = line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - line.IndexOf("(") -1);
                            if (name == "고성능" || name == "High performance")
                            {
                                string guid = line.Substring(line.IndexOf("GUID:") + 5, line.IndexOf("(") - (line.IndexOf("GUID:") + 5)).Trim();

                                HighPerfomanceGuid = guid;
                                if (line.Substring(line.IndexOf(")") + 1).IndexOf("*") != -1)
                                {
                                    state = State.HighPerformance;
                                }
                            }
                        }
                        else if (line.IndexOf("절전") != -1 || line.IndexOf("Power saver") != -1)
                        {
                            string name = line.Substring(line.IndexOf("(") + 1, line.IndexOf(")") - line.IndexOf("(") -1);
                            if (name == "절전" || name == "Power saver")
                            {
                                string guid = line.Substring(line.IndexOf("GUID:") + 5, line.IndexOf("(") - (line.IndexOf("GUID:") + 5)).Trim();

                                PowerSaverGuid = guid;
                                if (line.Substring(line.IndexOf(")") + 1).IndexOf("*") != -1)
                                {
                                    state = State.PowerSaver;
                                }
                            }
                        }
                    }
                    Thread.Sleep(100);
                }
                process.Close();
            })
            { IsBackground = true }.Start();
        }

        private void SetHighPerfomance()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            Process process = new Process();

            processInfo.FileName = "cmd.exe";
            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            process.StartInfo = processInfo;
            process.Start();

            process.StandardInput.Write(@"powercfg /setactive " + HighPerfomanceGuid + Environment.NewLine);
            process.StandardInput.Close();
            process.Close();

            SystemSounds.Hand.Play();
        }
        private void SetPowerSaver()
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            Process process = new Process();

            processInfo.FileName = "cmd.exe";
            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardInput = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;

            process.StartInfo = processInfo;
            process.Start();

            process.StandardInput.Write(@"powercfg /setactive " + PowerSaverGuid + Environment.NewLine);
            process.StandardInput.Close();
            process.Close();

            SystemSounds.Exclamation.Play();
        }


        private void 고성능ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHighPerfomance();
        }

        private void 절전ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPowerSaver();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ControlBox = false;
            if (state == State.HighPerformance)
            {
                notifyIcon1.Text = "고성능";
                label1.Text = "고성능";
                buttonHigh.Enabled = false;
                buttonSavePower.Enabled = true;
                contextMenuStrip1.Items[0].Text = "고성능 *";
                contextMenuStrip1.Items[1].Text = "절전";
            }
            else if (state == State.PowerSaver)
            {
                notifyIcon1.Text = "절전";
                label1.Text = "절전";
                buttonHigh.Enabled = true;
                buttonSavePower.Enabled = false;
                contextMenuStrip1.Items[0].Text = "고성능";
                contextMenuStrip1.Items[1].Text = "절전 *";
            }
            else
            {
                notifyIcon1.Text = "Power";
                label1.Text = "Power";
                buttonHigh.Enabled = true;
                buttonSavePower.Enabled = true;
                contextMenuStrip1.Items[0].Text = "고성능";
                contextMenuStrip1.Items[1].Text = "절전";
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (state == State.HighPerformance)
            {
                SetPowerSaver();
            }
            else if (state == State.PowerSaver)
            {
                SetHighPerfomance();
            }
        }

        bool tempHighControl;
        bool tempHighAlt;
        bool tempHighShift;
        Keys tempHighKeys;

        bool tempSaveControl;
        bool tempSaveAlt;
        bool tempSaveShift;
        Keys tempSaveKeys;

        private void SetHigh(bool bCtrl, bool bAlt, bool bShift, Keys key)
        {
            string text = "";
            Keys tempKeys = key;

            if (bCtrl == true)
            {
                text += "Ctrl";
            }
            if (bAlt == true)
            {
                if (text.Length != 0)
                {
                    text += " + ";
                }
                text += "Alt";
            }
            if (bShift == true)
            {
                if (text.Length != 0)
                {
                    text += " + ";
                }
                text += "Shift";
            }
            if ((int)tempKeys > 0)
            {
                if (false == (tempKeys == Keys.Control || tempKeys == Keys.Shift || tempKeys == Keys.Alt || tempKeys == Keys.Menu || tempKeys == Keys.ControlKey || tempKeys == Keys.ShiftKey))
                {
                    if (text.Length != 0)
                    {
                        text += " + ";
                    }
                    text += tempKeys.ToString();
                }
            }
            tempHighControl = bCtrl;
            tempHighAlt = bAlt;
            tempHighShift = bShift;
            tempHighKeys = tempKeys;

            textBoxHigh.Text = text;
        }

        private void textBoxHigh_KeyDown(object sender, KeyEventArgs e)
        {
            SetHigh(e.Control, e.Alt, e.Shift, e.KeyCode);
        }

        private void textBoxHigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SetSave(bool bCtrl, bool bAlt, bool bShift, Keys key)
        {
            string text = "";
            Keys tempKeys = key;

            if (bCtrl == true)
            {
                text += "Ctrl";
            }
            if (bAlt == true)
            {
                if (text.Length != 0)
                {
                    text += " + ";
                }
                text += "Alt";
            }
            if (bShift == true)
            {
                if (text.Length != 0)
                {
                    text += " + ";
                }
                text += "Shift";
            }
            if ((int)tempKeys > 0)
            {
                if (false == (tempKeys == Keys.Control || tempKeys == Keys.Shift || tempKeys == Keys.Alt || tempKeys == Keys.Menu || tempKeys == Keys.ControlKey || tempKeys == Keys.ShiftKey))
                {
                    if (text.Length != 0)
                    {
                        text += " + ";
                    }
                    text += tempKeys.ToString();
                }
            }
            tempSaveControl = bCtrl;
            tempSaveAlt = bAlt;
            tempSaveShift = bShift;
            tempSaveKeys = tempKeys;

            textBoxSave.Text = text;
        }

        private void textBoxSave_KeyDown(object sender, KeyEventArgs e)
        {
            SetSave(e.Control, e.Alt, e.Shift, e.KeyCode);
        }

        private void textBoxSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            highConfig.bAlt = tempHighAlt;
            highConfig.bCtrl = tempHighControl;
            highConfig.bShift = tempHighShift;
            highConfig.key = tempHighKeys;

            saveConfig.bAlt = tempSaveAlt;
            saveConfig.bCtrl = tempSaveControl;
            saveConfig.bShift = tempSaveShift;
            saveConfig.key = tempSaveKeys;

            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private void 세팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHigh(highConfig.bCtrl, highConfig.bAlt, highConfig.bShift, highConfig.key);
            SetSave(saveConfig.bCtrl, saveConfig.bAlt, saveConfig.bShift, saveConfig.key);

            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }

        private void buttonHigh_Click(object sender, EventArgs e)
        {
            SetHighPerfomance();
        }

        private void buttonSavePower_Click(object sender, EventArgs e)
        {
            SetPowerSaver();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
