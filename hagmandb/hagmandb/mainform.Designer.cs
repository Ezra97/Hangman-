namespace hagmandb
{
    partial class mainform
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
            this.button_new_game = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.labeluserguesser = new System.Windows.Forms.Label();
            this.labelletterschosen = new System.Windows.Forms.Label();
            this.label_errors = new System.Windows.Forms.Label();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_new_game
            // 
            this.button_new_game.Location = new System.Drawing.Point(12, 394);
            this.button_new_game.Name = "button_new_game";
            this.button_new_game.Size = new System.Drawing.Size(75, 23);
            this.button_new_game.TabIndex = 0;
            this.button_new_game.Text = "new game";
            this.button_new_game.UseVisualStyleBackColor = true;
            this.button_new_game.Click += new System.EventHandler(this.onclick);
            // 
            // label_answer
            // 
            this.label_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_answer.Location = new System.Drawing.Point(408, 327);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(110, 66);
            this.label_answer.TabIndex = 1;
            this.label_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeluserguesser
            // 
            this.labeluserguesser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeluserguesser.Location = new System.Drawing.Point(25, 217);
            this.labeluserguesser.Name = "labeluserguesser";
            this.labeluserguesser.Size = new System.Drawing.Size(516, 23);
            this.labeluserguesser.TabIndex = 3;
            this.labeluserguesser.Text = "what to guess";
            this.labeluserguesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelletterschosen
            // 
            this.labelletterschosen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelletterschosen.Location = new System.Drawing.Point(25, 256);
            this.labelletterschosen.Name = "labelletterschosen";
            this.labelletterschosen.Size = new System.Drawing.Size(516, 62);
            this.labelletterschosen.TabIndex = 4;
            this.labelletterschosen.Text = "letters already chosen";
            this.labelletterschosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_errors
            // 
            this.label_errors.Location = new System.Drawing.Point(382, 96);
            this.label_errors.Name = "label_errors";
            this.label_errors.Size = new System.Drawing.Size(100, 23);
            this.label_errors.TabIndex = 5;
            this.label_errors.Text = "label1";
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(23, 47);
            this.buttonV.Margin = new System.Windows.Forms.Padding(1);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(20, 20);
            this.buttonV.TabIndex = 6;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(1, 24);
            this.buttonK.Margin = new System.Windows.Forms.Padding(1);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(20, 20);
            this.buttonK.TabIndex = 29;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(1, 47);
            this.buttonU.Margin = new System.Windows.Forms.Padding(1);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(20, 20);
            this.buttonU.TabIndex = 28;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(199, 1);
            this.buttonJ.Margin = new System.Windows.Forms.Padding(1);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(20, 20);
            this.buttonJ.TabIndex = 27;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(199, 23);
            this.buttonT.Margin = new System.Windows.Forms.Padding(1);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(20, 20);
            this.buttonT.TabIndex = 26;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(177, 1);
            this.buttonI.Margin = new System.Windows.Forms.Padding(1);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(20, 20);
            this.buttonI.TabIndex = 25;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(178, 24);
            this.buttonS.Margin = new System.Windows.Forms.Padding(1);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(20, 20);
            this.buttonS.TabIndex = 24;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(155, 1);
            this.buttonH.Margin = new System.Windows.Forms.Padding(1);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(20, 20);
            this.buttonH.TabIndex = 23;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(112, 47);
            this.buttonZ.Margin = new System.Windows.Forms.Padding(1);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(20, 20);
            this.buttonZ.TabIndex = 22;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(156, 24);
            this.buttonR.Margin = new System.Windows.Forms.Padding(1);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(20, 20);
            this.buttonR.TabIndex = 21;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(134, 1);
            this.buttonG.Margin = new System.Windows.Forms.Padding(1);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(20, 20);
            this.buttonG.TabIndex = 20;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(90, 47);
            this.buttonY.Margin = new System.Windows.Forms.Padding(1);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(20, 20);
            this.buttonY.TabIndex = 19;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(134, 24);
            this.buttonQ.Margin = new System.Windows.Forms.Padding(1);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(20, 20);
            this.buttonQ.TabIndex = 18;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(112, 1);
            this.buttonF.Margin = new System.Windows.Forms.Padding(1);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(20, 20);
            this.buttonF.TabIndex = 17;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(68, 47);
            this.buttonX.Margin = new System.Windows.Forms.Padding(1);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(20, 20);
            this.buttonX.TabIndex = 16;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(112, 24);
            this.buttonP.Margin = new System.Windows.Forms.Padding(1);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(20, 20);
            this.buttonP.TabIndex = 15;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(90, 1);
            this.buttonE.Margin = new System.Windows.Forms.Padding(1);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(20, 20);
            this.buttonE.TabIndex = 14;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(46, 47);
            this.buttonW.Margin = new System.Windows.Forms.Padding(1);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(20, 20);
            this.buttonW.TabIndex = 13;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(89, 24);
            this.buttonO.Margin = new System.Windows.Forms.Padding(1);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(20, 20);
            this.buttonO.TabIndex = 12;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(68, 1);
            this.buttonD.Margin = new System.Windows.Forms.Padding(1);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(20, 20);
            this.buttonD.TabIndex = 11;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(67, 24);
            this.buttonN.Margin = new System.Windows.Forms.Padding(1);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(20, 20);
            this.buttonN.TabIndex = 10;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(46, 1);
            this.buttonC.Margin = new System.Windows.Forms.Padding(1);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(20, 20);
            this.buttonC.TabIndex = 9;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(46, 24);
            this.buttonM.Margin = new System.Windows.Forms.Padding(1);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(20, 20);
            this.buttonM.TabIndex = 8;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(23, 1);
            this.buttonB.Margin = new System.Windows.Forms.Padding(1);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(20, 20);
            this.buttonB.TabIndex = 7;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(23, 24);
            this.buttonL.Margin = new System.Windows.Forms.Padding(1);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(20, 20);
            this.buttonL.TabIndex = 30;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.onselectletter);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(1, 2);
            this.buttonA.Margin = new System.Windows.Forms.Padding(1);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(20, 20);
            this.buttonA.TabIndex = 31;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.onselectletter);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Controls.Add(this.buttonV);
            this.panel1.Controls.Add(this.buttonL);
            this.panel1.Controls.Add(this.buttonK);
            this.panel1.Controls.Add(this.buttonB);
            this.panel1.Controls.Add(this.buttonU);
            this.panel1.Controls.Add(this.buttonM);
            this.panel1.Controls.Add(this.buttonJ);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.buttonT);
            this.panel1.Controls.Add(this.buttonN);
            this.panel1.Controls.Add(this.buttonI);
            this.panel1.Controls.Add(this.buttonD);
            this.panel1.Controls.Add(this.buttonS);
            this.panel1.Controls.Add(this.buttonO);
            this.panel1.Controls.Add(this.buttonH);
            this.panel1.Controls.Add(this.buttonW);
            this.panel1.Controls.Add(this.buttonZ);
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Controls.Add(this.buttonR);
            this.panel1.Controls.Add(this.buttonP);
            this.panel1.Controls.Add(this.buttonG);
            this.panel1.Controls.Add(this.buttonX);
            this.panel1.Controls.Add(this.buttonY);
            this.panel1.Controls.Add(this.buttonF);
            this.panel1.Controls.Add(this.buttonQ);
            this.panel1.Location = new System.Drawing.Point(122, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 78);
            this.panel1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_errors);
            this.Controls.Add(this.labelletterschosen);
            this.Controls.Add(this.labeluserguesser);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_new_game);
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.onpaint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_new_game;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label labeluserguesser;
        private System.Windows.Forms.Label labelletterschosen;
        private System.Windows.Forms.Label label_errors;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Panel panel1;
    }
}

