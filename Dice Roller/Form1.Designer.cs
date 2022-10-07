namespace Dice_Roller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DieSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numberselection = new System.Windows.Forms.NumericUpDown();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.Rollbutton = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiceOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Numberselection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).BeginInit();
            this.SuspendLayout();
            // 
            // DieSelection
            // 
            this.DieSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DieSelection.ForeColor = System.Drawing.Color.Gold;
            this.DieSelection.FormattingEnabled = true;
            this.DieSelection.Items.AddRange(new object[] {
            "D4",
            "D6",
            "D8",
            "D10",
            "D12",
            "D20",
            "D100"});
            this.DieSelection.Location = new System.Drawing.Point(297, 160);
            this.DieSelection.Name = "DieSelection";
            this.DieSelection.Size = new System.Drawing.Size(182, 33);
            this.DieSelection.TabIndex = 0;
            this.DieSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(331, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Die Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(105, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Dice";
            // 
            // Numberselection
            // 
            this.Numberselection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Numberselection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numberselection.ForeColor = System.Drawing.Color.Gold;
            this.Numberselection.Location = new System.Drawing.Point(93, 160);
            this.Numberselection.Name = "Numberselection";
            this.Numberselection.Size = new System.Drawing.Size(180, 31);
            this.Numberselection.TabIndex = 5;
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.BackColor = System.Drawing.Color.Transparent;
            this.Resultlabel.ForeColor = System.Drawing.Color.Gold;
            this.Resultlabel.Location = new System.Drawing.Point(625, 162);
            this.Resultlabel.MinimumSize = new System.Drawing.Size(1, 0);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(1, 25);
            this.Resultlabel.TabIndex = 6;
            // 
            // Rollbutton
            // 
            this.Rollbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Rollbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rollbutton.ForeColor = System.Drawing.Color.Gold;
            this.Rollbutton.Location = new System.Drawing.Point(319, 227);
            this.Rollbutton.Name = "Rollbutton";
            this.Rollbutton.Size = new System.Drawing.Size(112, 34);
            this.Rollbutton.TabIndex = 7;
            this.Rollbutton.Text = "Roll";
            this.Rollbutton.UseVisualStyleBackColor = false;
            this.Rollbutton.Click += new System.EventHandler(this.Rollbutton_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifier.ForeColor = System.Drawing.Color.Gold;
            this.modifier.Location = new System.Drawing.Point(520, 161);
            this.modifier.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.modifier.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(46, 31);
            this.modifier.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(503, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modifier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(625, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Roll Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(625, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dice Values:";
            // 
            // DiceOut
            // 
            this.DiceOut.AutoSize = true;
            this.DiceOut.BackColor = System.Drawing.Color.Transparent;
            this.DiceOut.ForeColor = System.Drawing.Color.Gold;
            this.DiceOut.Location = new System.Drawing.Point(625, 236);
            this.DiceOut.MinimumSize = new System.Drawing.Size(1, 0);
            this.DiceOut.Name = "DiceOut";
            this.DiceOut.Size = new System.Drawing.Size(1, 25);
            this.DiceOut.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(277, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 54);
            this.label6.TabIndex = 13;
            this.label6.Text = "DiceMaster";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dice_Roller.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiceOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.Rollbutton);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.Numberselection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DieSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numberselection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox DieSelection;
        private Label label2;
        private Label label3;
        private NumericUpDown Numberselection;
        private Label Resultlabel;
        private Button Rollbutton;
        private NumericUpDown modifier;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label DiceOut;
        private Label label6;
    }
}