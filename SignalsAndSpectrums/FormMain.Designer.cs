namespace SignalsAndSpectrums
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.labelARatioNumber = new System.Windows.Forms.Label();
            this.labelARatioText = new System.Windows.Forms.Label();
            this.labelFShiftNumber = new System.Windows.Forms.Label();
            this.labelFShiftText = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelFDom = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxFDom = new System.Windows.Forms.TextBox();
            this.plotSignal = new OxyPlot.WindowsForms.PlotView();
            this.plotSpectrum = new OxyPlot.WindowsForms.PlotView();
            this.buttonScreen = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.labelARatioNumber);
            this.groupBoxSettings.Controls.Add(this.labelARatioText);
            this.groupBoxSettings.Controls.Add(this.labelFShiftNumber);
            this.groupBoxSettings.Controls.Add(this.labelFShiftText);
            this.groupBoxSettings.Controls.Add(this.buttonCalc);
            this.groupBoxSettings.Controls.Add(this.labelQ);
            this.groupBoxSettings.Controls.Add(this.labelP);
            this.groupBoxSettings.Controls.Add(this.labelV);
            this.groupBoxSettings.Controls.Add(this.labelFDom);
            this.groupBoxSettings.Controls.Add(this.textBoxQ);
            this.groupBoxSettings.Controls.Add(this.textBoxP);
            this.groupBoxSettings.Controls.Add(this.textBoxV);
            this.groupBoxSettings.Controls.Add(this.textBoxFDom);
            this.groupBoxSettings.Location = new System.Drawing.Point(650, 25);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 350);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            // 
            // labelARatioNumber
            // 
            this.labelARatioNumber.AutoSize = true;
            this.labelARatioNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelARatioNumber.Location = new System.Drawing.Point(25, 275);
            this.labelARatioNumber.Name = "labelARatioNumber";
            this.labelARatioNumber.Size = new System.Drawing.Size(36, 16);
            this.labelARatioNumber.TabIndex = 21;
            this.labelARatioNumber.Text = "NaN";
            // 
            // labelARatioText
            // 
            this.labelARatioText.AutoSize = true;
            this.labelARatioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelARatioText.Location = new System.Drawing.Point(25, 250);
            this.labelARatioText.Name = "labelARatioText";
            this.labelARatioText.Size = new System.Drawing.Size(107, 16);
            this.labelARatioText.TabIndex = 20;
            this.labelARatioText.Text = "Amplitudes ratio:";
            // 
            // labelFShiftNumber
            // 
            this.labelFShiftNumber.AutoSize = true;
            this.labelFShiftNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFShiftNumber.Location = new System.Drawing.Point(25, 325);
            this.labelFShiftNumber.Name = "labelFShiftNumber";
            this.labelFShiftNumber.Size = new System.Drawing.Size(36, 16);
            this.labelFShiftNumber.TabIndex = 19;
            this.labelFShiftNumber.Text = "NaN";
            // 
            // labelFShiftText
            // 
            this.labelFShiftText.AutoSize = true;
            this.labelFShiftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFShiftText.Location = new System.Drawing.Point(25, 300);
            this.labelFShiftText.Name = "labelFShiftText";
            this.labelFShiftText.Size = new System.Drawing.Size(123, 16);
            this.labelFShiftText.TabIndex = 18;
            this.labelFShiftText.Text = "Frequency shift, Hz:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(25, 225);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(100, 23);
            this.buttonCalc.TabIndex = 17;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQ.Location = new System.Drawing.Point(25, 175);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(85, 16);
            this.labelQ.TabIndex = 16;
            this.labelQ.Text = "Quality factor";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP.Location = new System.Drawing.Point(25, 125);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(57, 16);
            this.labelP.TabIndex = 15;
            this.labelP.Text = "Path (m)";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelV.Location = new System.Drawing.Point(25, 75);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(89, 16);
            this.labelV.TabIndex = 14;
            this.labelV.Text = "Velocity (m/s)";
            // 
            // labelFDom
            // 
            this.labelFDom.AutoSize = true;
            this.labelFDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFDom.Location = new System.Drawing.Point(25, 25);
            this.labelFDom.Name = "labelFDom";
            this.labelFDom.Size = new System.Drawing.Size(154, 16);
            this.labelFDom.TabIndex = 13;
            this.labelFDom.Text = "Dominant frequency (Hz)";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(25, 200);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 12;
            this.textBoxQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPressed);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(25, 150);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 20);
            this.textBoxP.TabIndex = 11;
            this.textBoxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPressed);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(25, 100);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 20);
            this.textBoxV.TabIndex = 10;
            this.textBoxV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPressed);
            // 
            // textBoxFDom
            // 
            this.textBoxFDom.Location = new System.Drawing.Point(25, 50);
            this.textBoxFDom.Name = "textBoxFDom";
            this.textBoxFDom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFDom.TabIndex = 9;
            this.textBoxFDom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleTextBox_KeyPressed);
            // 
            // plotSignal
            // 
            this.plotSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotSignal.BackColor = System.Drawing.SystemColors.Window;
            this.plotSignal.Location = new System.Drawing.Point(25, 25);
            this.plotSignal.Name = "plotSignal";
            this.plotSignal.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotSignal.Size = new System.Drawing.Size(600, 200);
            this.plotSignal.TabIndex = 4;
            this.plotSignal.Text = "plotSignal";
            this.plotSignal.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotSignal.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotSignal.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotSpectrum
            // 
            this.plotSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotSpectrum.BackColor = System.Drawing.SystemColors.Window;
            this.plotSpectrum.Location = new System.Drawing.Point(25, 225);
            this.plotSpectrum.Name = "plotSpectrum";
            this.plotSpectrum.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotSpectrum.Size = new System.Drawing.Size(600, 200);
            this.plotSpectrum.TabIndex = 5;
            this.plotSpectrum.Text = "plotView1";
            this.plotSpectrum.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotSpectrum.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotSpectrum.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // buttonScreen
            // 
            this.buttonScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScreen.Location = new System.Drawing.Point(675, 381);
            this.buttonScreen.Name = "buttonScreen";
            this.buttonScreen.Size = new System.Drawing.Size(100, 23);
            this.buttonScreen.TabIndex = 22;
            this.buttonScreen.Text = "Print screen";
            this.buttonScreen.UseVisualStyleBackColor = true;
            this.buttonScreen.Click += new System.EventHandler(this.buttonScreen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.buttonScreen);
            this.Controls.Add(this.plotSpectrum);
            this.Controls.Add(this.plotSignal);
            this.Controls.Add(this.groupBoxSettings);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signals and spectrums";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelFDom;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxFDom;
        private OxyPlot.WindowsForms.PlotView plotSignal;
        private OxyPlot.WindowsForms.PlotView plotSpectrum;
        private System.Windows.Forms.Label labelARatioNumber;
        private System.Windows.Forms.Label labelARatioText;
        private System.Windows.Forms.Label labelFShiftNumber;
        private System.Windows.Forms.Label labelFShiftText;
        private System.Windows.Forms.Button buttonScreen;
    }
}

