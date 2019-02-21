namespace PostMakinası
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Coz = new System.Windows.Forms.Button();
            this.lblAktifKural = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rbKodYeri = new System.Windows.Forms.RichTextBox();
            this.btnBirlestir = new System.Windows.Forms.Button();
            this.btnFark = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(335, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btn_Coz
            // 
            this.btn_Coz.Location = new System.Drawing.Point(350, 405);
            this.btn_Coz.Name = "btn_Coz";
            this.btn_Coz.Size = new System.Drawing.Size(102, 49);
            this.btn_Coz.TabIndex = 2;
            this.btn_Coz.Text = "ÇÖZ";
            this.btn_Coz.UseVisualStyleBackColor = true;
            this.btn_Coz.Click += new System.EventHandler(this.btn_Coz_Click);
            // 
            // lblAktifKural
            // 
            this.lblAktifKural.AutoSize = true;
            this.lblAktifKural.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifKural.Location = new System.Drawing.Point(594, 428);
            this.lblAktifKural.Name = "lblAktifKural";
            this.lblAktifKural.Size = new System.Drawing.Size(112, 26);
            this.lblAktifKural.TabIndex = 3;
            this.lblAktifKural.Text = "Aktif Kural";
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(776, 471);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(107, 53);
            this.btnIleri.TabIndex = 10;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(497, 471);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(107, 53);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 53);
            this.button5.TabIndex = 11;
            this.button5.Text = "TEMİZLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rbKodYeri
            // 
            this.rbKodYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKodYeri.Location = new System.Drawing.Point(49, 15);
            this.rbKodYeri.Name = "rbKodYeri";
            this.rbKodYeri.Size = new System.Drawing.Size(275, 488);
            this.rbKodYeri.TabIndex = 0;
            this.rbKodYeri.Text = "<-2\n? 3;1\nv 4\n!";
            this.rbKodYeri.SelectionChanged += new System.EventHandler(this.rbKodYeri_SelectionChanged);
            this.rbKodYeri.VScroll += new System.EventHandler(this.rbKodYeri_VScroll);
            this.rbKodYeri.FontChanged += new System.EventHandler(this.rbKodYeri_FontChanged);
            this.rbKodYeri.TextChanged += new System.EventHandler(this.rbKodYeri_TextChanged);
            // 
            // btnBirlestir
            // 
            this.btnBirlestir.Location = new System.Drawing.Point(49, 509);
            this.btnBirlestir.Name = "btnBirlestir";
            this.btnBirlestir.Size = new System.Drawing.Size(55, 34);
            this.btnBirlestir.TabIndex = 13;
            this.btnBirlestir.Text = "A+B";
            this.btnBirlestir.UseVisualStyleBackColor = true;
            this.btnBirlestir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFark
            // 
            this.btnFark.Location = new System.Drawing.Point(110, 509);
            this.btnFark.Name = "btnFark";
            this.btnFark.Size = new System.Drawing.Size(55, 34);
            this.btnFark.TabIndex = 14;
            this.btnFark.Text = "A-B";
            this.btnFark.UseVisualStyleBackColor = true;
            this.btnFark.Click += new System.EventHandler(this.btnFark_Click);
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.SystemColors.Control;
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb2.Location = new System.Drawing.Point(12, 12);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tb2.Size = new System.Drawing.Size(34, 491);
            this.tb2.TabIndex = 16;
            this.tb2.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(335, 218);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(719, 174);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.btnFark);
            this.Controls.Add(this.btnBirlestir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblAktifKural);
            this.Controls.Add(this.btn_Coz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbKodYeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Post Makinası Hüseyin Kutlukkaya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Coz;
        private System.Windows.Forms.Label lblAktifKural;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rbKodYeri;
        private System.Windows.Forms.Button btnBirlestir;
        private System.Windows.Forms.Button btnFark;
        private System.Windows.Forms.RichTextBox tb2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

