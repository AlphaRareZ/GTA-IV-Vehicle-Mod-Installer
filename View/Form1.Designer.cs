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
            selectDir.Location = new Point(680, 115);
            selectDir.Margin = new Padding(3, 4, 3, 4);
            selectDir.Name = "selectDir";
            selectDir.Size = new Size(89, 28);
            selectDir.TabIndex = 0;
            selectDir.Text = "Select";
            selectDir.UseVisualStyleBackColor = true;
            selectDir.Click += button1_Click;
            // 
            // gameDirTxt
            // 
            gameDirTxt.Location = new Point(116, 115);
            gameDirTxt.Margin = new Padding(3, 4, 3, 4);
            gameDirTxt.Name = "gameDirTxt";
            gameDirTxt.Size = new Size(558, 27);
            gameDirTxt.TabIndex = 3;
            gameDirTxt.TextChanged += textBox1_TextChanged;
            // 
            // gameDir
            // 
            gameDir.AutoSize = true;
            gameDir.Location = new Point(-2, 115);
            gameDir.Name = "gameDir";
            gameDir.Size = new Size(114, 20);
            gameDir.TabIndex = 6;
            gameDir.Text = "GTAIV Directory";
            // 
            // vehicleNameTxt
            // 
            vehicleNameTxt.Location = new Point(116, 165);
            vehicleNameTxt.Margin = new Padding(3, 4, 3, 4);
            vehicleNameTxt.Name = "vehicleNameTxt";
            vehicleNameTxt.Size = new Size(558, 27);
            vehicleNameTxt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 165);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 9;
            label1.Text = "Vehicle Name";
            // 
            // handlingTxt
            // 
            handlingTxt.Location = new Point(116, 215);
            handlingTxt.Margin = new Padding(3, 4, 3, 4);
            handlingTxt.Name = "handlingTxt";
            handlingTxt.Size = new Size(558, 27);
            handlingTxt.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-2, 215);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 12;
            label2.Text = "Handling Data";
            // 
            // vehicleDataTxt
            // 
            vehicleDataTxt.Location = new Point(116, 258);
            vehicleDataTxt.Margin = new Padding(3, 4, 3, 4);
            vehicleDataTxt.Name = "vehicleDataTxt";
            vehicleDataTxt.Size = new Size(558, 27);
            vehicleDataTxt.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 261);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 15;
            label3.Text = "Vehicle Data";
            // 
            // selectWft
            // 
            selectWft.Location = new Point(685, 369);
            selectWft.Margin = new Padding(3, 4, 3, 4);
            selectWft.Name = "selectWft";
            selectWft.Size = new Size(84, 28);
            selectWft.TabIndex = 16;
            selectWft.Text = "Select";
            selectWft.UseVisualStyleBackColor = true;
            selectWft.Click += button2_Click;
            // 
            // wftTxt
            // 
            wftTxt.Location = new Point(116, 370);
            wftTxt.Margin = new Padding(3, 4, 3, 4);
            wftTxt.Name = "wftTxt";
            wftTxt.Size = new Size(558, 27);
            wftTxt.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 369);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 18;
            label4.Text = "Texture (*.wft)";
            // 
            // selectWtd
            // 
            selectWtd.Location = new Point(685, 420);
            selectWtd.Margin = new Padding(3, 4, 3, 4);
            selectWtd.Name = "selectWtd";
            selectWtd.Size = new Size(84, 28);
            selectWtd.TabIndex = 19;
            selectWtd.Text = "Select";
            selectWtd.UseVisualStyleBackColor = true;
            selectWtd.Click += button3_Click;
            // 
            // wtdTxt
            // 
            wtdTxt.Location = new Point(116, 420);
            wtdTxt.Margin = new Padding(3, 4, 3, 4);
            wtdTxt.Name = "wtdTxt";
            wtdTxt.Size = new Size(558, 27);
            wtdTxt.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-2, 420);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 21;
            label5.Text = "Texture (*.wtd)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-2, 314);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 24;
            label6.Text = "Carcols Data";
            // 
            // carcolsTxt
            // 
            carcolsTxt.Location = new Point(116, 314);
            carcolsTxt.Margin = new Padding(3, 4, 3, 4);
            carcolsTxt.Name = "carcolsTxt";
            carcolsTxt.Size = new Size(558, 27);
            carcolsTxt.TabIndex = 23;
            // 
            // checkCars3
            // 
            checkCars3.AutoSize = true;
            checkCars3.Location = new Point(680, 295);
            checkCars3.Name = "checkCars3";
            checkCars3.Size = new Size(65, 24);
            checkCars3.TabIndex = 25;
            checkCars3.Text = "cars3";
            checkCars3.UseVisualStyleBackColor = true;
            checkCars3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkCars4
            // 
            checkCars4.AutoSize = true;
            checkCars4.Location = new Point(680, 325);
            checkCars4.Name = "checkCars4";
            checkCars4.Size = new Size(65, 24);
            checkCars4.TabIndex = 26;
            checkCars4.Text = "cars4";
            checkCars4.UseVisualStyleBackColor = true;
            checkCars4.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // installBtn
            // 
            installBtn.Location = new Point(318, 491);
            installBtn.Margin = new Padding(3, 4, 3, 4);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(140, 58);
            installBtn.TabIndex = 22;
            installBtn.Text = "Install";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += button4_Click;
            installBtn.Enabled = false;
            // 
            // ModInstallerByAlaaDLord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 562);
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
            Margin = new Padding(3, 4, 3, 4);
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

