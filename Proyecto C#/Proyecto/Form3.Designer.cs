namespace Proyecto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pbPri = new PictureBox();
            pb1Pan = new PictureBox();
            pbMorena = new PictureBox();
            label1 = new Label();
            txtSuggetion = new TextBox();
            btnVote1 = new Button();
            btnVote3 = new Button();
            btnVote2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1Pan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMorena).BeginInit();
            SuspendLayout();
            // 
            // pbPri
            // 
            pbPri.Image = Properties.Resources.PRI__partido_revolucionario_institucional__logo__Mexico_;
            pbPri.Location = new Point(43, 26);
            pbPri.Name = "pbPri";
            pbPri.Size = new Size(117, 114);
            pbPri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPri.TabIndex = 0;
            pbPri.TabStop = false;
            // 
            // pb1Pan
            // 
            pb1Pan.Image = (Image)resources.GetObject("pb1Pan.Image");
            pb1Pan.Location = new Point(43, 159);
            pb1Pan.Name = "pb1Pan";
            pb1Pan.Size = new Size(117, 115);
            pb1Pan.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1Pan.TabIndex = 1;
            pb1Pan.TabStop = false;
            // 
            // pbMorena
            // 
            pbMorena.Image = Properties.Resources._1024px_Morena_partido_logo;
            pbMorena.Location = new Point(43, 289);
            pbMorena.Name = "pbMorena";
            pbMorena.Size = new Size(117, 114);
            pbMorena.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMorena.TabIndex = 2;
            pbMorena.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(725, 138);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 3;
            label1.Text = "Suggestion Box:";
            // 
            // txtSuggetion
            // 
            txtSuggetion.Location = new Point(555, 170);
            txtSuggetion.Multiline = true;
            txtSuggetion.Name = "txtSuggetion";
            txtSuggetion.Size = new Size(298, 104);
            txtSuggetion.TabIndex = 4;
            // 
            // btnVote1
            // 
            btnVote1.BackColor = SystemColors.ScrollBar;
            btnVote1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVote1.Location = new Point(187, 72);
            btnVote1.Name = "btnVote1";
            btnVote1.Size = new Size(75, 30);
            btnVote1.TabIndex = 5;
            btnVote1.Text = "VOTE";
            btnVote1.UseVisualStyleBackColor = false;
            btnVote1.Click += btnVote1_Click;
            // 
            // btnVote3
            // 
            btnVote3.BackColor = SystemColors.ScrollBar;
            btnVote3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVote3.Location = new Point(187, 323);
            btnVote3.Name = "btnVote3";
            btnVote3.Size = new Size(75, 31);
            btnVote3.TabIndex = 6;
            btnVote3.Text = "VOTE";
            btnVote3.UseVisualStyleBackColor = false;
            btnVote3.Click += btnVote3_Click;
            // 
            // btnVote2
            // 
            btnVote2.BackColor = SystemColors.ScrollBar;
            btnVote2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVote2.Location = new Point(187, 202);
            btnVote2.Name = "btnVote2";
            btnVote2.Size = new Size(75, 31);
            btnVote2.TabIndex = 7;
            btnVote2.Text = "VOTE";
            btnVote2.UseVisualStyleBackColor = false;
            btnVote2.Click += btnVote2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(725, 289);
            button1.Name = "button1";
            button1.Size = new Size(119, 36);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 475);
            Controls.Add(button1);
            Controls.Add(btnVote2);
            Controls.Add(btnVote3);
            Controls.Add(btnVote1);
            Controls.Add(txtSuggetion);
            Controls.Add(label1);
            Controls.Add(pbMorena);
            Controls.Add(pb1Pan);
            Controls.Add(pbPri);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pbPri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1Pan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMorena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPri;
        private PictureBox pb1Pan;
        private PictureBox pbMorena;
        private Label label1;
        private TextBox txtSuggetion;
        private Button btnVote1;
        private Button btnVote3;
        private Button btnVote2;
        private Button button1;
    }
}