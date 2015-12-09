using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace LongMacro
{
    public partial class Form1 : Form
    {
        Macro m;
        Thread t;

        public Form1()
        {
            m = new Macro(this);
            t = new Thread(m.Run);
            InitializeComponent();
        }

        delegate void Delegate(Macro m);

        public void update(Macro m)
        {
            if (this.labelCurrentStep.InvokeRequired)
            {
                Form1.Delegate delegate0 = new Form1.Delegate(this.update);
                base.Invoke(delegate0, new object[] { m });
                return;
            }
            this.labelCurrentStep.Text = m.currentStep.ToString();
            this.labelExp.Text = m.exp.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.IsAlive)
            {
                this.buttonRunMacro.Text = "Start macro";
                t.Abort();
            }

            else
            {
                String[] commands = textBoxMacros.Lines;
                m.macroKeys = new List<Command>(); //clear the existing list

                try
                {
                    Macro.minimumMaxCP = Convert.ToInt32(this.textBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid value for max CP");
                    return;
                }

                foreach (String command in commands)
                {
                    //ignore comments
                    if (command[0] == ';') continue;

                    //single character commands
                    if (command.Length == 1)
                    {
                        m.macroKeys.Add(new Command(ConvertCommandToKeys(command.ToUpper()), null));
                    }

                    //commands with descriptions
                    else
                    {
                        String[] parts = command.Split('(');
                        String name = null;

                        if (parts.Length > 1)
                        {
                            name = parts[1].Replace(")", "");
                        }
                        Keys k = ConvertCommandToKeys(parts[0]);

                        if (k == Keys.None)
                        {
                            MessageBox.Show("Error parsing command: " + command);
                            return;
                        }

                        m.macroKeys.Add(new Command(k, name));
                    }
                }

                this.buttonRunMacro.Text = "Stop macro";
                m.SkipGreatStrides = this.checkBoxSkipGreatStrides.Checked;
                t = new Thread(m.Run);
                t.Start();
            }
        }

        private Keys ConvertCommandToKeys(String command)
        {
            Keys key;
            if (char.IsDigit(command[0]))
            {
                Enum.TryParse("D" + command, out key); //convert number keys to Keys enum
            }

            else
            {
                Enum.TryParse(command, out key);
            }

            return key;
        }

        private void buttonLoadMacro_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        List<String> NewCommands = new List<String>();
                        using (var sr = new StreamReader(myStream))
                        {
                            while (!sr.EndOfStream)
                            {
                                NewCommands.Add(sr.ReadLine());
                            }
                        }
                        this.textBoxMacros.Lines = NewCommands.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file from disk! " + ex.Message);
                }
            }
        }

        private void buttonSaveMacro_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (var sw = new StreamWriter(myStream))
                    {
                        String[] commands = textBoxMacros.Lines;

                        foreach (String command in commands)
                        {
                            sw.WriteLine(command);
                        }
                        sw.Close();
                    }
                }
            }
        }
    }
}
