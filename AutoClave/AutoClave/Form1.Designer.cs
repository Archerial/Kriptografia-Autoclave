namespace AutoClave
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
            this.txtbox_word = new System.Windows.Forms.TextBox();
            this.txtbox_key = new System.Windows.Forms.TextBox();
            this.lbl_word = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_srcword = new System.Windows.Forms.Label();
            this.lbl_srckey = new System.Windows.Forms.Label();
            this.lbl_secret = new System.Windows.Forms.Label();
            this.lbl_srctitok = new System.Windows.Forms.Label();
            this.lbl_srcszoveg = new System.Windows.Forms.Label();
            this.lbl_srckulcs = new System.Windows.Forms.Label();
            this.dgv_alphabetic = new System.Windows.Forms.DataGridView();
            this.lstbox_steps = new System.Windows.Forms.ListBox();
            this.lbl_steps = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alphabetic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_word
            // 
            this.txtbox_word.Location = new System.Drawing.Point(93, 12);
            this.txtbox_word.Name = "txtbox_word";
            this.txtbox_word.Size = new System.Drawing.Size(100, 20);
            this.txtbox_word.TabIndex = 0;
            // 
            // txtbox_key
            // 
            this.txtbox_key.Location = new System.Drawing.Point(93, 56);
            this.txtbox_key.Name = "txtbox_key";
            this.txtbox_key.Size = new System.Drawing.Size(100, 20);
            this.txtbox_key.TabIndex = 1;
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Location = new System.Drawing.Point(6, 18);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(28, 13);
            this.lbl_word.TabIndex = 2;
            this.lbl_word.Text = "Szó:";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(6, 62);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(36, 13);
            this.lbl_key.TabIndex = 3;
            this.lbl_key.Text = "Kulcs:";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(93, 123);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_srcword
            // 
            this.lbl_srcword.AutoSize = true;
            this.lbl_srcword.Location = new System.Drawing.Point(212, 14);
            this.lbl_srcword.Name = "lbl_srcword";
            this.lbl_srcword.Size = new System.Drawing.Size(78, 13);
            this.lbl_srcword.TabIndex = 5;
            this.lbl_srcword.Text = "Forrás Szöveg:";
            // 
            // lbl_srckey
            // 
            this.lbl_srckey.AutoSize = true;
            this.lbl_srckey.Location = new System.Drawing.Point(212, 59);
            this.lbl_srckey.Name = "lbl_srckey";
            this.lbl_srckey.Size = new System.Drawing.Size(36, 13);
            this.lbl_srckey.TabIndex = 6;
            this.lbl_srckey.Text = "Kulcs:";
            // 
            // lbl_secret
            // 
            this.lbl_secret.AutoSize = true;
            this.lbl_secret.Location = new System.Drawing.Point(215, 119);
            this.lbl_secret.Name = "lbl_secret";
            this.lbl_secret.Size = new System.Drawing.Size(95, 13);
            this.lbl_secret.TabIndex = 7;
            this.lbl_secret.Text = "Titkosított szöveg:";
            // 
            // lbl_srctitok
            // 
            this.lbl_srctitok.AutoSize = true;
            this.lbl_srctitok.Location = new System.Drawing.Point(319, 119);
            this.lbl_srctitok.Name = "lbl_srctitok";
            this.lbl_srctitok.Size = new System.Drawing.Size(0, 13);
            this.lbl_srctitok.TabIndex = 8;
            // 
            // lbl_srcszoveg
            // 
            this.lbl_srcszoveg.AutoSize = true;
            this.lbl_srcszoveg.Location = new System.Drawing.Point(319, 11);
            this.lbl_srcszoveg.Name = "lbl_srcszoveg";
            this.lbl_srcszoveg.Size = new System.Drawing.Size(0, 13);
            this.lbl_srcszoveg.TabIndex = 9;
            // 
            // lbl_srckulcs
            // 
            this.lbl_srckulcs.AutoSize = true;
            this.lbl_srckulcs.Location = new System.Drawing.Point(319, 58);
            this.lbl_srckulcs.Name = "lbl_srckulcs";
            this.lbl_srckulcs.Size = new System.Drawing.Size(0, 13);
            this.lbl_srckulcs.TabIndex = 10;
            // 
            // dgv_alphabetic
            // 
            this.dgv_alphabetic.AllowUserToAddRows = false;
            this.dgv_alphabetic.AllowUserToDeleteRows = false;
            this.dgv_alphabetic.AllowUserToResizeColumns = false;
            this.dgv_alphabetic.AllowUserToResizeRows = false;
            this.dgv_alphabetic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_alphabetic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_alphabetic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_alphabetic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_alphabetic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alphabetic.ColumnHeadersVisible = false;
            this.dgv_alphabetic.Location = new System.Drawing.Point(12, 152);
            this.dgv_alphabetic.Name = "dgv_alphabetic";
            this.dgv_alphabetic.RowHeadersVisible = false;
            this.dgv_alphabetic.Size = new System.Drawing.Size(600, 600);
            this.dgv_alphabetic.TabIndex = 11;
            // 
            // lstbox_steps
            // 
            this.lstbox_steps.FormattingEnabled = true;
            this.lstbox_steps.Location = new System.Drawing.Point(647, 152);
            this.lstbox_steps.Name = "lstbox_steps";
            this.lstbox_steps.Size = new System.Drawing.Size(232, 602);
            this.lstbox_steps.TabIndex = 12;
            // 
            // lbl_steps
            // 
            this.lbl_steps.AutoSize = true;
            this.lbl_steps.Location = new System.Drawing.Point(647, 103);
            this.lbl_steps.Name = "lbl_steps";
            this.lbl_steps.Size = new System.Drawing.Size(51, 13);
            this.lbl_steps.TabIndex = 13;
            this.lbl_steps.Text = "Lépések:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(804, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 803);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_steps);
            this.Controls.Add(this.lstbox_steps);
            this.Controls.Add(this.dgv_alphabetic);
            this.Controls.Add(this.lbl_srckulcs);
            this.Controls.Add(this.lbl_srcszoveg);
            this.Controls.Add(this.lbl_srctitok);
            this.Controls.Add(this.lbl_secret);
            this.Controls.Add(this.lbl_srckey);
            this.Controls.Add(this.lbl_srcword);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.txtbox_key);
            this.Controls.Add(this.txtbox_word);
            this.Name = "Form1";
            this.Text = "Autoclave";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alphabetic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_word;
        private System.Windows.Forms.TextBox txtbox_key;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_srcword;
        private System.Windows.Forms.Label lbl_srckey;
        private System.Windows.Forms.Label lbl_secret;
        private System.Windows.Forms.Label lbl_srctitok;
        private System.Windows.Forms.Label lbl_srcszoveg;
        private System.Windows.Forms.Label lbl_srckulcs;
        private System.Windows.Forms.DataGridView dgv_alphabetic;
        private System.Windows.Forms.ListBox lstbox_steps;
        private System.Windows.Forms.Label lbl_steps;
        private System.Windows.Forms.Button btn_exit;
    }
}

