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
            Api.MoveJoint(_id, _jointHandle, position, true);
        }
    }
}
