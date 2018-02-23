namespace I3Zad1
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
            this.lbIzvodjaci = new System.Windows.Forms.ListBox();
            this.lbAlbumi = new System.Windows.Forms.ListBox();
            this.tbEditedIzvodjac = new System.Windows.Forms.TextBox();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.btnUpdateIzvodjac = new System.Windows.Forms.Button();
            this.btnSpremiXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIzvodjaci
            // 
            this.lbIzvodjaci.FormattingEnabled = true;
            this.lbIzvodjaci.ItemHeight = 16;
            this.lbIzvodjaci.Location = new System.Drawing.Point(12, 60);
            this.lbIzvodjaci.Name = "lbIzvodjaci";
            this.lbIzvodjaci.Size = new System.Drawing.Size(217, 212);
            this.lbIzvodjaci.TabIndex = 0;
            this.lbIzvodjaci.SelectedIndexChanged += new System.EventHandler(this.lbIzvodjaci_SelectedIndexChanged);
            // 
            // lbAlbumi
            // 
            this.lbAlbumi.FormattingEnabled = true;
            this.lbAlbumi.ItemHeight = 16;
            this.lbAlbumi.Location = new System.Drawing.Point(364, 60);
            this.lbAlbumi.Name = "lbAlbumi";
            this.lbAlbumi.Size = new System.Drawing.Size(213, 212);
            this.lbAlbumi.TabIndex = 1;
            this.lbAlbumi.SelectedIndexChanged += new System.EventHandler(this.lbAlbumi_SelectedIndexChanged);
            // 
            // tbEditedIzvodjac
            // 
            this.tbEditedIzvodjac.Location = new System.Drawing.Point(12, 292);
            this.tbEditedIzvodjac.Name = "tbEditedIzvodjac";
            this.tbEditedIzvodjac.Size = new System.Drawing.Size(217, 22);
            this.tbEditedIzvodjac.TabIndex = 2;
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Location = new System.Drawing.Point(364, 290);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(213, 23);
            this.btnDeleteAlbum.TabIndex = 3;
            this.btnDeleteAlbum.Text = "Delete album";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // btnUpdateIzvodjac
            // 
            this.btnUpdateIzvodjac.Location = new System.Drawing.Point(12, 331);
            this.btnUpdateIzvodjac.Name = "btnUpdateIzvodjac";
            this.btnUpdateIzvodjac.Size = new System.Drawing.Size(217, 23);
            this.btnUpdateIzvodjac.TabIndex = 4;
            this.btnUpdateIzvodjac.Text = "Update izvodjac";
            this.btnUpdateIzvodjac.UseVisualStyleBackColor = true;
            this.btnUpdateIzvodjac.Click += new System.EventHandler(this.btnUpdateIzvodjac_Click);
            // 
            // btnSpremiXML
            // 
            this.btnSpremiXML.Location = new System.Drawing.Point(13, 371);
            this.btnSpremiXML.Name = "btnSpremiXML";
            this.btnSpremiXML.Size = new System.Drawing.Size(216, 23);
            this.btnSpremiXML.TabIndex = 5;
            this.btnSpremiXML.Text = "Spremi XML";
            this.btnSpremiXML.UseVisualStyleBackColor = true;
            this.btnSpremiXML.Click += new System.EventHandler(this.btnSpremiXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Izvodjaci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Albumi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremiXML);
            this.Controls.Add(this.btnUpdateIzvodjac);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.tbEditedIzvodjac);
            this.Controls.Add(this.lbAlbumi);
            this.Controls.Add(this.lbIzvodjaci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIzvodjaci;
        private System.Windows.Forms.ListBox lbAlbumi;
        private System.Windows.Forms.TextBox tbEditedIzvodjac;
        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Button btnUpdateIzvodjac;
        private System.Windows.Forms.Button btnSpremiXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

