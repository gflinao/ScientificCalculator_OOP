
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
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnPctg = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(66, 391);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(48, 43);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btnEq
            // 
            this.btnEq.BackColor = System.Drawing.Color.Orange;
            this.btnEq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEq.ForeColor = System.Drawing.Color.White;
            this.btnEq.Location = new System.Drawing.Point(174, 391);
            this.btnEq.Name = "btnEq";
            this.btnEq.Size = new System.Drawing.Size(48, 43);
            this.btnEq.TabIndex = 1;
            this.btnEq.Text = "=";
            this.btnEq.UseVisualStyleBackColor = false;
            this.btnEq.Click += new System.EventHandler(this.btnEq_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Orange;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(228, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Orange;
            this.btnSub.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(228, 341);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(48, 43);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Orange;
            this.btnMul.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.Color.White;
            this.btnMul.Location = new System.Drawing.Point(228, 292);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(48, 43);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Orange;
            this.btnDiv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(228, 243);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(48, 43);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btn_ArthOP);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(120, 391);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 43);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btnPN
            // 
            this.btnPN.BackColor = System.Drawing.Color.White;
            this.btnPN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPN.Location = new System.Drawing.Point(12, 391);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(48, 43);
            this.btnPN.TabIndex = 7;
            this.btnPN.Text = "±";
            this.btnPN.UseVisualStyleBackColor = false;
            this.btnPN.Click += new System.EventHandler(this.btnPN_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(174, 342);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 43);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(120, 342);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 43);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(66, 342);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 43);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(66, 244);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 43);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(120, 244);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 43);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(174, 244);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 43);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(66, 293);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 43);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(120, 293);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 43);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(174, 293);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 43);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_NumOP);
            // 
            // txtbxDisplay
            // 
            this.txtbxDisplay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbxDisplay.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDisplay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtbxDisplay.Location = new System.Drawing.Point(12, 51);
            this.txtbxDisplay.Multiline = true;
            this.txtbxDisplay.Name = "txtbxDisplay";
            this.txtbxDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbxDisplay.Size = new System.Drawing.Size(264, 76);
            this.txtbxDisplay.TabIndex = 17;
            this.txtbxDisplay.Text = "0";
            this.txtbxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOPr
            // 
            this.lblOPr.AutoSize = true;
            this.lblOPr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblOPr.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblOPr.Location = new System.Drawing.Point(22, 101);
            this.lblOPr.Name = "lblOPr";
            this.lblOPr.Size = new System.Drawing.Size(0, 19);
            this.lblOPr.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(228, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 43);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Orange;
            this.btnCE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(174, 195);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 43);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(12, 342);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(48, 43);
            this.btnMod.TabIndex = 21;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnx2
            // 
            this.btnx2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnx2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx2.ForeColor = System.Drawing.Color.White;
            this.btnx2.Location = new System.Drawing.Point(66, 196);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(48, 43);
            this.btnx2.TabIndex = 22;
            this.btnx2.Text = "x²\t";
            this.btnx2.UseVisualStyleBackColor = false;
            this.btnx2.Click += new System.EventHandler(this.btnx2_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.Color.White;
            this.btnPi.Location = new System.Drawing.Point(12, 194);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(48, 43);
            this.btnPi.TabIndex = 23;
            this.btnPi.Text = "𝜋";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.White;
            this.btnLn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(12, 293);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(48, 43);
            this.btnLn.TabIndex = 24;
            this.btnLn.Text = "ln (x)";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.White;
            this.btnExp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(12, 245);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(48, 43);
            this.btnExp.TabIndex = 25;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnx3
            // 
            this.btnx3.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnx3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx3.ForeColor = System.Drawing.Color.White;
            this.btnx3.Location = new System.Drawing.Point(120, 195);
            this.btnx3.Name = "btnx3";
            this.btnx3.Size = new System.Drawing.Size(48, 43);
            this.btnx3.TabIndex = 26;
            this.btnx3.Text = "x³";
            this.btnx3.UseVisualStyleBackColor = false;
            this.btnx3.Click += new System.EventHandler(this.btnx3_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Red;
            this.btnOff.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(228, 164);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(48, 25);
            this.btnOff.TabIndex = 32;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSqrt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.Location = new System.Drawing.Point(174, 164);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(48, 25);
            this.btnSqrt.TabIndex = 33;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.Color.White;
            this.btnTan.Location = new System.Drawing.Point(120, 164);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(48, 25);
            this.btnTan.TabIndex = 34;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.Location = new System.Drawing.Point(66, 164);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(48, 25);
            this.btnSin.TabIndex = 35;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(12, 164);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(48, 25);
            this.btnCos.TabIndex = 36;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCosh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.ForeColor = System.Drawing.Color.White;
            this.btnCosh.Location = new System.Drawing.Point(12, 133);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(48, 25);
            this.btnCosh.TabIndex = 39;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSinh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.ForeColor = System.Drawing.Color.White;
            this.btnSinh.Location = new System.Drawing.Point(66, 133);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(48, 25);
            this.btnSinh.TabIndex = 40;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTanh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.ForeColor = System.Drawing.Color.White;
            this.btnTanh.Location = new System.Drawing.Point(120, 133);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(48, 25);
            this.btnTanh.TabIndex = 41;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnPctg
            // 
            this.btnPctg.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPctg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPctg.ForeColor = System.Drawing.Color.White;
            this.btnPctg.Location = new System.Drawing.Point(228, 133);
            this.btnPctg.Name = "btnPctg";
            this.btnPctg.Size = new System.Drawing.Size(48, 25);
            this.btnPctg.TabIndex = 42;
            this.btnPctg.Text = "%";
            this.btnPctg.UseVisualStyleBackColor = false;
            this.btnPctg.Click += new System.EventHandler(this.btnPctg_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLog.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(174, 133);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(48, 25);
            this.btnLog.TabIndex = 43;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(288, 446);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPctg);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnOff);
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
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnPctg;
        private System.Windows.Forms.Button btnLog;
    }
}

