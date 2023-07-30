namespace Donguler
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
            progres = new ProgressBar();
            btPositive = new Button();
            btNegative = new Button();
            SuspendLayout();
            // 
            // progres
            // 
            progres.Location = new Point(12, 30);
            progres.Maximum = 90;
            progres.Name = "progres";
            progres.Size = new Size(762, 99);
            progres.TabIndex = 0;
            // 
            // btPositive
            // 
            btPositive.Location = new Point(12, 151);
            btPositive.Name = "btPositive";
            btPositive.Size = new Size(191, 111);
            btPositive.TabIndex = 1;
            btPositive.Text = "+";
            btPositive.UseVisualStyleBackColor = true;
            btPositive.Click += btPositive_Click;
            // 
            // btNegative
            // 
            btNegative.Location = new Point(583, 151);
            btNegative.Name = "btNegative";
            btNegative.Size = new Size(191, 111);
            btNegative.TabIndex = 1;
            btNegative.Text = "-";
            btNegative.UseVisualStyleBackColor = true;
            btNegative.Click += btNegative_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 289);
            Controls.Add(btNegative);
            Controls.Add(btPositive);
            Controls.Add(progres);
            Name = "Form1";
            Text = "frm";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progres;
        private Button btPositive;
        private Button btNegative;
    }
}