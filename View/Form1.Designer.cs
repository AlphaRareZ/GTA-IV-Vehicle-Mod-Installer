namespace ModInstaller
{
    partial class ModInstallerByAlaaDLord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModInstallerByAlaaDLord));
            directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            selectDir = new Button();
            gameDirTxt = new TextBox();
            gameDir = new Label();
            vehicleNameTxt = new TextBox();
            label1 = new Label();
            handlingTxt = new TextBox();
            label2 = new Label();
            vehicleDataTxt = new TextBox();
            label3 = new Label();
            selectWft = new Button();
            wftTxt = new TextBox();
            label4 = new Label();
            selectWtd = new Button();
            wtdTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            carcolsTxt = new TextBox();
            checkCars3 = new CheckBox();
            checkCars4 = new CheckBox();
            installBtn = new Button();
            SuspendLayout();
            // 
            // selectDir
            // 
            selectDir.Location = new Point(595, 86);
            selectDir.Name = "selectDir";
            selectDir.Size = new Size(78, 21);
            selectDir.TabIndex = 0;
            selectDir.Text = "Select";
            selectDir.UseVisualStyleBackColor = true;
            selectDir.Click += button1_Click;
            // 
            // gameDirTxt
            // 
            gameDirTxt.Location = new Point(102, 86);
            gameDirTxt.Name = "gameDirTxt";
            gameDirTxt.Size = new Size(489, 23);
            gameDirTxt.TabIndex = 3;
            gameDirTxt.TextChanged += gameDirTxt_TextChanged;
            // 
            // gameDir
            // 
            gameDir.AutoSize = true;
            gameDir.Location = new Point(-2, 86);
            gameDir.Name = "gameDir";
            gameDir.Size = new Size(89, 15);
            gameDir.TabIndex = 6;
            gameDir.Text = "GTAIV Directory";
            // 
            // vehicleNameTxt
            // 
            vehicleNameTxt.Location = new Point(102, 124);
            vehicleNameTxt.Name = "vehicleNameTxt";
            vehicleNameTxt.Size = new Size(489, 23);
            vehicleNameTxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 124);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Vehicle Name";
            // 
            // handlingTxt
            // 
            handlingTxt.Location = new Point(102, 161);
            handlingTxt.Name = "handlingTxt";
            handlingTxt.Size = new Size(489, 23);
            handlingTxt.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-2, 161);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 12;
            label2.Text = "Handling Data";
            // 
            // vehicleDataTxt
            // 
            vehicleDataTxt.Location = new Point(102, 194);
            vehicleDataTxt.Name = "vehicleDataTxt";
            vehicleDataTxt.Size = new Size(489, 23);
            vehicleDataTxt.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 196);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 15;
            label3.Text = "Vehicle Data";
            // 
            // selectWft
            // 
            selectWft.Location = new Point(599, 277);
            selectWft.Name = "selectWft";
            selectWft.Size = new Size(74, 21);
            selectWft.TabIndex = 16;
            selectWft.Text = "Select";
            selectWft.UseVisualStyleBackColor = true;
            selectWft.Click += button2_Click;
            // 
            // wftTxt
            // 
            wftTxt.Location = new Point(102, 278);
            wftTxt.Name = "wftTxt";
            wftTxt.Size = new Size(489, 23);
            wftTxt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 277);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 18;
            label4.Text = "Texture (*.wft)";
            // 
            // selectWtd
            // 
            selectWtd.Location = new Point(599, 315);
            selectWtd.Name = "selectWtd";
            selectWtd.Size = new Size(74, 21);
            selectWtd.TabIndex = 19;
            selectWtd.Text = "Select";
            selectWtd.UseVisualStyleBackColor = true;
            selectWtd.Click += button3_Click;
            // 
            // wtdTxt
            // 
            wtdTxt.Location = new Point(102, 315);
            wtdTxt.Name = "wtdTxt";
            wtdTxt.Size = new Size(489, 23);
            wtdTxt.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-2, 315);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 21;
            label5.Text = "Texture (*.wtd)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-2, 236);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 24;
            label6.Text = "Carcols Data";
            // 
            // carcolsTxt
            // 
            carcolsTxt.Location = new Point(102, 236);
            carcolsTxt.Name = "carcolsTxt";
            carcolsTxt.Size = new Size(489, 23);
            carcolsTxt.TabIndex = 23;
            // 
            // checkCars3
            // 
            checkCars3.AutoSize = true;
            checkCars3.Location = new Point(595, 221);
            checkCars3.Margin = new Padding(3, 2, 3, 2);
            checkCars3.Name = "checkCars3";
            checkCars3.Size = new Size(53, 19);
            checkCars3.TabIndex = 25;
            checkCars3.Text = "cars3";
            checkCars3.UseVisualStyleBackColor = true;
            checkCars3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkCars4
            // 
            checkCars4.AutoSize = true;
            checkCars4.Location = new Point(595, 244);
            checkCars4.Margin = new Padding(3, 2, 3, 2);
            checkCars4.Name = "checkCars4";
            checkCars4.Size = new Size(53, 19);
            checkCars4.TabIndex = 26;
            checkCars4.Text = "cars4";
            checkCars4.UseVisualStyleBackColor = true;
            checkCars4.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // installBtn
            // 
            installBtn.Enabled = false;
            installBtn.Location = new Point(278, 368);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(122, 44);
            installBtn.TabIndex = 22;
            installBtn.Text = "Install";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += button4_Click;
            // 
            // ModInstallerByAlaaDLord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 422);
            Controls.Add(checkCars4);
            Controls.Add(checkCars3);
            Controls.Add(label6);
            Controls.Add(carcolsTxt);
            Controls.Add(installBtn);
            Controls.Add(label5);
            Controls.Add(wtdTxt);
            Controls.Add(selectWtd);
            Controls.Add(label4);
            Controls.Add(wftTxt);
            Controls.Add(selectWft);
            Controls.Add(label3);
            Controls.Add(vehicleDataTxt);
            Controls.Add(label2);
            Controls.Add(handlingTxt);
            Controls.Add(label1);
            Controls.Add(vehicleNameTxt);
            Controls.Add(gameDir);
            Controls.Add(gameDirTxt);
            Controls.Add(selectDir);
            DoubleBuffered = true;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModInstallerByAlaaDLord";
            Text = "Mod Installer By AlaaDLord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        internal Button selectDir;
        internal TextBox gameDirTxt;
        internal Label gameDir;
        internal TextBox vehicleNameTxt;
        internal Label label1;
        internal TextBox handlingTxt;
        internal Label label2;
        internal TextBox vehicleDataTxt;
        internal Label label3;
        internal Button selectWft;
        internal TextBox wftTxt;
        internal Label label4;
        internal Button selectWtd;
        internal TextBox wtdTxt;
        internal Label label5;
        internal Label label6;
        internal TextBox carcolsTxt;
        internal CheckBox checkCars3;
        internal CheckBox checkCars4;
        internal Button installBtn;
    }
}

