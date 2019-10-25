namespace feladatform
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
            this.nev = new System.Windows.Forms.Label();
            this.szuldatum = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.nevBox = new System.Windows.Forms.TextBox();
            this.szulDatumBox = new System.Windows.Forms.TextBox();
            this.kedvencHobbi = new System.Windows.Forms.Label();
            this.listSzovegek = new System.Windows.Forms.ListBox();
            this.ujHobbi = new System.Windows.Forms.Label();
            this.hozzaadTxt = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnMent = new System.Windows.Forms.Button();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nev.Location = new System.Drawing.Point(12, 9);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(47, 22);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            // 
            // szuldatum
            // 
            this.szuldatum.AutoSize = true;
            this.szuldatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.szuldatum.Location = new System.Drawing.Point(12, 39);
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(111, 22);
            this.szuldatum.TabIndex = 1;
            this.szuldatum.Text = "Szül. Dátum:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nem.Location = new System.Drawing.Point(12, 65);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(52, 22);
            this.nem.TabIndex = 2;
            this.nem.Text = "Nem:";
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ferfi.Location = new System.Drawing.Point(129, 67);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(39, 26);
            this.ferfi.TabIndex = 3;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "F";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.no.Location = new System.Drawing.Point(188, 67);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 26);
            this.no.TabIndex = 4;
            this.no.TabStop = true;
            this.no.Text = "N";
            this.no.UseVisualStyleBackColor = true;
            // 
            // nevBox
            // 
            this.nevBox.Location = new System.Drawing.Point(129, 12);
            this.nevBox.Name = "nevBox";
            this.nevBox.Size = new System.Drawing.Size(100, 20);
            this.nevBox.TabIndex = 5;
            // 
            // szulDatumBox
            // 
            this.szulDatumBox.Location = new System.Drawing.Point(129, 41);
            this.szulDatumBox.Name = "szulDatumBox";
            this.szulDatumBox.Size = new System.Drawing.Size(100, 20);
            this.szulDatumBox.TabIndex = 6;
            // 
            // kedvencHobbi
            // 
            this.kedvencHobbi.AutoSize = true;
            this.kedvencHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kedvencHobbi.Location = new System.Drawing.Point(235, 10);
            this.kedvencHobbi.Name = "kedvencHobbi";
            this.kedvencHobbi.Size = new System.Drawing.Size(134, 22);
            this.kedvencHobbi.TabIndex = 7;
            this.kedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // listSzovegek
            // 
            this.listSzovegek.FormattingEnabled = true;
            this.listSzovegek.Location = new System.Drawing.Point(254, 39);
            this.listSzovegek.Name = "listSzovegek";
            this.listSzovegek.Size = new System.Drawing.Size(102, 134);
            this.listSzovegek.TabIndex = 8;
            // 
            // ujHobbi
            // 
            this.ujHobbi.AutoSize = true;
            this.ujHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ujHobbi.Location = new System.Drawing.Point(148, 179);
            this.ujHobbi.Name = "ujHobbi";
            this.ujHobbi.Size = new System.Drawing.Size(81, 22);
            this.ujHobbi.TabIndex = 10;
            this.ujHobbi.Text = "Új hobbi:";
            // 
            // hozzaadTxt
            // 
            this.hozzaadTxt.Location = new System.Drawing.Point(256, 179);
            this.hozzaadTxt.Name = "hozzaadTxt";
            this.hozzaadTxt.Size = new System.Drawing.Size(100, 20);
            this.hozzaadTxt.TabIndex = 11;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(281, 205);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 12;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(188, 288);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(75, 23);
            this.btnMent.TabIndex = 13;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // btnBetolt
            // 
            this.btnBetolt.Location = new System.Drawing.Point(281, 288);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(75, 23);
            this.btnBetolt.TabIndex = 14;
            this.btnBetolt.Text = "Betöltés";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File(*.txt|*.txt|All files|(*.*)*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File(*.txt|*.txt|All files|(*.*)*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 329);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.hozzaadTxt);
            this.Controls.Add(this.ujHobbi);
            this.Controls.Add(this.listSzovegek);
            this.Controls.Add(this.kedvencHobbi);
            this.Controls.Add(this.szulDatumBox);
            this.Controls.Add(this.nevBox);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szuldatum;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.TextBox nevBox;
        private System.Windows.Forms.TextBox szulDatumBox;
        private System.Windows.Forms.Label kedvencHobbi;
        private System.Windows.Forms.ListBox listSzovegek;
        private System.Windows.Forms.Label ujHobbi;
        private System.Windows.Forms.TextBox hozzaadTxt;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnMent;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

