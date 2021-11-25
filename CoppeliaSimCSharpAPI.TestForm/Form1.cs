using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoppeliaSimCSharpAPI.TestForm
{
    public partial class Form1 : Form
    {
        private int _id;
        private int[] _jointHandle = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _id = Api.Connect(textBoxAddress.Text, (int)numericUpDownPort.Value);
            for (int i = 0; i < _jointHandle.Length; i++)
            {
                _jointHandle[i] = Api.GetObjectHandle(_id, $"UR5_joint{i + 1}");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Api.Disconnect(_id);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            var position = new float[]
            {
                (float)numericUpDownJ1.Value,
                (float)numericUpDownJ2.Value,
                (float)numericUpDownJ3.Value,
                (float)numericUpDownJ4.Value,
                (float)numericUpDownJ5.Value,
                (float)numericUpDownJ6.Value
            };
            Api.MoveJoint(_id, _jointHandle, position, true, _jointHandle.Length);
        }

        private void buttonGetPosition_Click(object sender, EventArgs e)
        {
            var position = new float[6];
            Api.GetJointPosition(_id, _jointHandle, position, _jointHandle.Length);
            MessageBox.Show($"{position[0]}\r\n" +
                            $"{position[1]}\r\n" +
                            $"{position[2]}\r\n" +
                            $"{position[3]}\r\n" +
                            $"{position[4]}\r\n" +
                            $"{position[5]}",
                            "Now position");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                buttonDisconnect.PerformClick();
            }
            catch (Exception)
            {
                /* Do nothing. */
            }
        }
    }
}
