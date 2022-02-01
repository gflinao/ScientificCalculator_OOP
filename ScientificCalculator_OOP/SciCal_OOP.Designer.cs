
namespace ScientificCalculator_OOP
{
    partial class Calculator
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
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEq = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPN = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.txtbxDisplay = new System.Windows.Forms.TextBox();
            this.lblOPr = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnx2 = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnx3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(174, 391);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(48, 43);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btnEq
            // 
            this.btnEq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEq.Location = new System.Drawing.Point(228, 391);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(48, 43);
            this.btnEq.TabIndex = 1;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = true;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(228, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(228, 293);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(48, 43);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(228, 244);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(48, 43);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(228, 195);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(48, 43);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(120, 391);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 43);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btnPN
            // 
            this.btnPN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPN.Location = new System.Drawing.Point(66, 391);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(48, 43);
            this.btnPN.TabIndex = 7;
            this.btnPN.Text = "±";
            this.btnPN.UseVisualStyleBackColor = true;
            this.btnPN.Click += new System.EventHandler(this.btnPN_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(174, 342);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 43);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(120, 342);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 43);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(66, 342);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 43);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(66, 244);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 43);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(120, 244);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 43);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(174, 244);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 43);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(66, 293);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 43);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(120, 293);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 43);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(174, 293);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 43);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // txtbxDisplay
            // 
            this.txtbxDisplay.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtbxDisplay.Multiline = true;
            this.txtbxDisplay.Name = "txtbxDisplay";
            this.txtbxDisplay.Size = new System.Drawing.Size(239, 76);
            this.txtbxDisplay.TabIndex = 17;
            this.txtbxDisplay.Text = "0";
            this.txtbxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOPr
            // 
            this.lblOPr.AutoSize = true;
            this.lblOPr.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPr.Location = new System.Drawing.Point(26, 59);
            this.lblOPr.Name = "lblOPr";
            this.lblOPr.Size = new System.Drawing.Size(19, 19);
            this.lblOPr.TabIndex = 18;
            this.lblOPr.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(174, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 43);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(120, 195);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 43);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(12, 342);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(48, 43);
            this.btnMod.TabIndex = 21;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnx2
            // 
            this.btnx2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx2.Location = new System.Drawing.Point(12, 195);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(48, 43);
            this.btnx2.TabIndex = 22;
            this.btnx2.Text = "x²\t";
            this.btnx2.UseVisualStyleBackColor = true;
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(12, 391);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(48, 43);
            this.btnPi.TabIndex = 23;
            this.btnPi.Text = "𝜋";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(12, 293);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(48, 43);
            this.btnLn.TabIndex = 24;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(12, 245);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(48, 43);
            this.btnExp.TabIndex = 25;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // btnx3
            // 
            this.btnx3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx3.Location = new System.Drawing.Point(66, 195);
            this.btnx3.Name = "btnx3";
            this.btnx3.Size = new System.Drawing.Size(48, 43);
            this.btnx3.TabIndex = 26;
            this.btnx3.Text = "x³";
            this.btnx3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 25);
            this.button5.TabIndex = 31;
            this.button5.Text = "Cos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 25);
            this.button1.TabIndex = 32;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(174, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 25);
            this.button2.TabIndex = 33;
            this.button2.Text = " 2nd";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(120, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 25);
            this.button3.TabIndex = 34;
            this.button3.Text = "Tan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(66, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 25);
            this.button4.TabIndex = 35;
            this.button4.Text = "Sin";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(288, 446);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnx3);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnx2);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblOPr);
            this.Controls.Add(this.txtbxDisplay);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPN);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEq);
            this.Controls.Add(this.btnDot);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Click += new System.EventHandler(this.btn_NumOP);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEq;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPN;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.TextBox txtbxDisplay;
        private System.Windows.Forms.Label lblOPr;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnx2;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnx3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

