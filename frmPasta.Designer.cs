namespace Donguler
{
    partial class frmPasta
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
            components = new System.ComponentModel.Container();
            l1 = new Label();
            p1 = new ProgressBar();
            l2 = new Label();
            p2 = new ProgressBar();
            l3 = new Label();
            p3 = new ProgressBar();
            l4 = new Label();
            p4 = new ProgressBar();
            t1 = new System.Windows.Forms.Timer(components);
            t2 = new System.Windows.Forms.Timer(components);
            t3 = new System.Windows.Forms.Timer(components);
            t4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(2, 9);
            l1.Name = "l1";
            l1.Size = new Size(160, 15);
            l1.TabIndex = 0;
            l1.Text = "Un ve Yumurta Karıştırılıyor...";
            // 
            // p1
            // 
            p1.Location = new Point(2, 27);
            p1.MarqueeAnimationSpeed = 1000;
            p1.Name = "p1";
            p1.Size = new Size(798, 23);
            p1.TabIndex = 1;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Location = new Point(2, 59);
            l2.Name = "l2";
            l2.Size = new Size(137, 15);
            l2.TabIndex = 0;
            l2.Text = "Çırpma İşlemi Yapılıyor...";
            // 
            // p2
            // 
            p2.Location = new Point(2, 77);
            p2.MarqueeAnimationSpeed = 1000;
            p2.Name = "p2";
            p2.Size = new Size(798, 23);
            p2.TabIndex = 1;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(2, 112);
            l3.Name = "l3";
            l3.Size = new Size(208, 15);
            l3.TabIndex = 0;
            l3.Text = "Malzemeler Ekleniyor ve Karıştırılıyor...";
            // 
            // p3
            // 
            p3.Location = new Point(2, 130);
            p3.MarqueeAnimationSpeed = 1000;
            p3.Name = "p3";
            p3.Size = new Size(798, 23);
            p3.TabIndex = 1;
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(2, 168);
            l4.Name = "l4";
            l4.Size = new Size(95, 15);
            l4.TabIndex = 0;
            l4.Text = "Pasta Pişiriliyor...";
            // 
            // p4
            // 
            p4.Location = new Point(2, 186);
            p4.MarqueeAnimationSpeed = 1000;
            p4.Name = "p4";
            p4.Size = new Size(798, 23);
            p4.TabIndex = 1;
            // 
            // t1
            // 
            t1.Enabled = true;
            t1.Interval = 1000;
            t1.Tick += t1_Tick;
            // 
            // t2
            // 
            t2.Interval = 1000;
            t2.Tick += t2_Tick;
            // 
            // t3
            // 
            t3.Interval = 1000;
            t3.Tick += t3_Tick;
            // 
            // t4
            // 
            t4.Interval = 1000;
            t4.Tick += t4_Tick;
            // 
            // frmPasta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 308);
            Controls.Add(p4);
            Controls.Add(p3);
            Controls.Add(p2);
            Controls.Add(l4);
            Controls.Add(l3);
            Controls.Add(l2);
            Controls.Add(p1);
            Controls.Add(l1);
            Name = "frmPasta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPasta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l1;
        private ProgressBar p1;
        private Label l2;
        private ProgressBar p2;
        private Label l3;
        private ProgressBar p3;
        private Label l4;
        private ProgressBar p4;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Timer t3;
        private System.Windows.Forms.Timer t4;
    }
}