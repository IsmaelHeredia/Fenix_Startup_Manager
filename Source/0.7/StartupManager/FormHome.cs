// Fenix Startup Manager 0.7
// © Ismael Heredia , Argentina , 2017
// Based on : http://pastebin.com/KvgHVyBc

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.Media;

namespace StartupManager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        public void listar_startup()
        {
            lbNames.Items.Clear();
            lbValues.Items.Clear();
            lvStartupFiles.Items.Clear();

            toolStripStatusLabel1.Text = "[+] Getting Keys ...";
            this.Refresh();

            try
            {

                RegistryKey registro = null;
                if (cmbTypes.Text == "HKEY_LOCAL_MACHINE")
                {
                    registro = Registry.LocalMachine;
                }
                else if (cmbTypes.Text == "HKEY_CURRENT_USER")
                {
                    registro = Registry.CurrentUser;
                }
                else
                {
                    registro = Registry.LocalMachine;
                }

                registro = registro.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false);

                foreach (string names in registro.GetValueNames())
                {
                    if (names != "")
                    {
                        string valor = registro.GetValue(names).ToString();
                        lbNames.Items.Add(names);
                        lbValues.Items.Add(valor);
                        ListViewItem agregar = new ListViewItem();
                        agregar.Text = names;
                        agregar.SubItems.Add(valor);
                        lvStartupFiles.Items.Add(agregar);

                    }
                }

                registro.Close();

                gbStartupFiles.Text = "Startup Files ["+lbNames.Items.Count.ToString()+"]";

                toolStripStatusLabel1.Text = "[+] Finished";
                this.Refresh();

                if (lbValues.Items.Count == 0)
                {
                    MessageBox.Show("Error , Try running as admin");
                }

                SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.scanfin);
                sound.Play();

            }

            catch
            {
                MessageBox.Show("Error , Try running as admin");
            }
        }

        private void tmUpdateProcess_Tick(object sender, EventArgs e)
        {
            listar_startup();
        }

        private void ListValues_Click(object sender, EventArgs e)
        {
            listar_startup();
        }

        private void CreateValue_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();

            DialogResult question = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {

                string name = Interaction.InputBox("Enter Name", "Create Value", "");
                string value = Interaction.InputBox("Enter Value", "Create Value", "");

                try
                {
                    RegistryKey registro = null;
                    if (cmbTypes.Text == "HKEY_LOCAL_MACHINE")
                    {
                        registro = Registry.LocalMachine;
                    }
                    else if (cmbTypes.Text == "HKEY_CURRENT_USER")
                    {
                        registro = Registry.CurrentUser;
                    }
                    else
                    {
                        registro = Registry.LocalMachine;
                    }
                    registro = registro.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registro.CreateSubKey(name);
                    registro.SetValue(name, value, RegistryValueKind.String);
                    registro.Close();
                    toolStripStatusLabel1.Text = "[+] Successfully created";
                    this.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error , Try running as admin");
                }
            }

            listar_startup();
        }

        private void EditValue_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();

            DialogResult question = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                try
                {
                    RegistryKey registro = null;
                    if (cmbTypes.Text == "HKEY_LOCAL_MACHINE")
                    {
                        registro = Registry.LocalMachine;
                    }
                    else if (cmbTypes.Text == "HKEY_CURRENT_USER")
                    {
                        registro = Registry.CurrentUser;
                    }
                    else
                    {
                        registro = Registry.LocalMachine;
                    }
                    registro = registro.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    string name = lbNames.Items[lvStartupFiles.FocusedItem.Index].ToString();
                    string valor = registro.GetValue(name).ToString();
                    string valornuevo = Interaction.InputBox("Enter new Value", "Edit Value", valor);
                    registro.SetValue(name, valornuevo, RegistryValueKind.String);
                    registro.Close();
                    toolStripStatusLabel1.Text = "[+] Edited successfully";
                    this.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error , Try running as admin");
                }
            }

            listar_startup();
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();

            DialogResult question = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                try
                {

                    string valoraborrar = lbNames.Items[lvStartupFiles.FocusedItem.Index].ToString();
                    RegistryKey registro = null;
                    if (cmbTypes.Text == "HKEY_LOCAL_MACHINE")
                    {
                        registro = Registry.LocalMachine;
                    }
                    else if (cmbTypes.Text == "HKEY_CURRENT_USER")
                    {
                        registro = Registry.CurrentUser;
                    }
                    else
                    {
                        registro = Registry.LocalMachine;
                    }
                    registro = registro.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registro.DeleteValue(valoraborrar);
                    registro.Close();
                    toolStripStatusLabel1.Text = "[+] Successfully removed";
                    this.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error , Try running as admin");
                }
            }

            listar_startup();
        }

        private void ReadName_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();
            MessageBox.Show(lbNames.Items[lvStartupFiles.FocusedItem.Index].ToString());
        }

        private void ReadTheValue_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();
            MessageBox.Show(lbValues.Items[lvStartupFiles.FocusedItem.Index].ToString());
        }

        private void CopyName_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(lbNames.Items[lvStartupFiles.FocusedItem.Index].ToString());
                toolStripStatusLabel1.Text = "[+] Successfully copied to clipboard";
                this.Refresh();
            }
            catch
            {
                //
            }
        }

        private void CopyValue_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.click);
            sound.Play();
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(lbValues.Items[lvStartupFiles.FocusedItem.Index].ToString());
                toolStripStatusLabel1.Text = "[+] Successfully copied to clipboard";
                this.Refresh();
            }
            catch
            {
                //
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(FenixStartupManager.Properties.Resources.formcreate);
            sound.Play();

            listar_startup();
        }

    }
}
