namespace CoppeliaSimCSharpAPI.TestForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.buttonMove = new System.Windows.Forms.Button();
            this.numericUpDownJ1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJ2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJ3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJ4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJ5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownJ6 = new System.Windows.Forms.NumericUpDown();
            this.buttonGetPosition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(93, 61);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(159, 73);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(93, 163);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(159, 73);
            this.buttonDisconnect.TabIndex = 0;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(348, 82);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 31);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.Text = "127.0.0.1";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(477, 83);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownPort.TabIndex = 2;
            this.numericUpDownPort.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(399, 484);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(159, 73);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // numericUpDownJ1
            // 
            this.numericUpDownJ1.Location = new System.Drawing.Point(414, 262);
            this.numericUpDownJ1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ1.Name = "numericUpDownJ1";
            this.numericUpDownJ1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ1.TabIndex = 4;
            this.numericUpDownJ1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownJ2
            // 
            this.numericUpDownJ2.Location = new System.Drawing.Point(414, 299);
            this.numericUpDownJ2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ2.Name = "numericUpDownJ2";
            this.numericUpDownJ2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ2.TabIndex = 4;
            this.numericUpDownJ2.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownJ3
            // 
            this.numericUpDownJ3.Location = new System.Drawing.Point(414, 336);
            this.numericUpDownJ3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ3.Name = "numericUpDownJ3";
            this.numericUpDownJ3.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ3.TabIndex = 4;
            this.numericUpDownJ3.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownJ4
            // 
            this.numericUpDownJ4.Location = new System.Drawing.Point(414, 373);
            this.numericUpDownJ4.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ4.Name = "numericUpDownJ4";
            this.numericUpDownJ4.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ4.TabIndex = 4;
            this.numericUpDownJ4.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownJ5
            // 
            this.numericUpDownJ5.Location = new System.Drawing.Point(414, 410);
            this.numericUpDownJ5.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ5.Name = "numericUpDownJ5";
            this.numericUpDownJ5.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ5.TabIndex = 4;
            this.numericUpDownJ5.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDownJ6
            // 
            this.numericUpDownJ6.Location = new System.Drawing.Point(414, 447);
            this.numericUpDownJ6.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownJ6.Name = "numericUpDownJ6";
            this.numericUpDownJ6.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownJ6.TabIndex = 4;
            this.numericUpDownJ6.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // buttonGetPosition
            // 
            this.buttonGetPosition.Location = new System.Drawing.Point(592, 484);
            this.buttonGetPosition.Name = "buttonGetPosition";
            this.buttonGetPosition.Size = new System.Drawing.Size(159, 73);
            this.buttonGetPosition.TabIndex = 5;
            this.buttonGetPosition.Text = "Get Position";
            this.buttonGetPosition.UseVisualStyleBackColor = true;
            this.buttonGetPosition.Click += new System.EventHandler(this.buttonGetPosition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 626);
            this.Controls.Add(this.buttonGetPosition);
            this.Controls.Add(this.numericUpDownJ6);
            this.Controls.Add(this.numericUpDownJ5);
            this.Controls.Add(this.numericUpDownJ4);
            this.Controls.Add(this.numericUpDownJ3);
            this.Controls.Add(this.numericUpDownJ2);
            this.Controls.Add(this.numericUpDownJ1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.numericUpDownPort);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "CoppeliaSim C# API Test Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJ6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.NumericUpDown numericUpDownJ1;
        private System.Windows.Forms.NumericUpDown numericUpDownJ2;
        private System.Windows.Forms.NumericUpDown numericUpDownJ3;
        private System.Windows.Forms.NumericUpDown numericUpDownJ4;
        private System.Windows.Forms.NumericUpDown numericUpDownJ5;
        private System.Windows.Forms.NumericUpDown numericUpDownJ6;
        private System.Windows.Forms.Button buttonGetPosition;
    }
}

