namespace LongMacro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPageMacro = new System.Windows.Forms.TabPage();
            this.labelCurrentStep = new System.Windows.Forms.Label();
            this.labelCurrentStepHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRunMacro = new System.Windows.Forms.Button();
            this.buttonSaveMacro = new System.Windows.Forms.Button();
            this.buttonLoadMacro = new System.Windows.Forms.Button();
            this.textBoxMacros = new System.Windows.Forms.TextBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBoxSkillOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxSkipGreatStrides = new System.Windows.Forms.CheckBox();
            this.groupBoxMacroOptions = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelExpHeader = new System.Windows.Forms.Label();
            this.tabPageMacro.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBoxSkillOptions.SuspendLayout();
            this.groupBoxMacroOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageMacro
            // 
            this.tabPageMacro.Controls.Add(this.labelCurrentStep);
            this.tabPageMacro.Controls.Add(this.labelCurrentStepHeader);
            this.tabPageMacro.Controls.Add(this.label1);
            this.tabPageMacro.Controls.Add(this.buttonRunMacro);
            this.tabPageMacro.Controls.Add(this.buttonSaveMacro);
            this.tabPageMacro.Controls.Add(this.buttonLoadMacro);
            this.tabPageMacro.Controls.Add(this.textBoxMacros);
            this.tabPageMacro.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacro.Name = "tabPageMacro";
            this.tabPageMacro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacro.Size = new System.Drawing.Size(401, 486);
            this.tabPageMacro.TabIndex = 0;
            this.tabPageMacro.Text = "Macro";
            this.tabPageMacro.UseVisualStyleBackColor = true;
            // 
            // labelCurrentStep
            // 
            this.labelCurrentStep.AutoSize = true;
            this.labelCurrentStep.Location = new System.Drawing.Point(74, 460);
            this.labelCurrentStep.Name = "labelCurrentStep";
            this.labelCurrentStep.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentStep.TabIndex = 7;
            this.labelCurrentStep.Text = "0";
            // 
            // labelCurrentStepHeader
            // 
            this.labelCurrentStepHeader.AutoSize = true;
            this.labelCurrentStepHeader.Location = new System.Drawing.Point(8, 460);
            this.labelCurrentStepHeader.Name = "labelCurrentStepHeader";
            this.labelCurrentStepHeader.Size = new System.Drawing.Size(69, 13);
            this.labelCurrentStepHeader.TabIndex = 6;
            this.labelCurrentStepHeader.Text = "Current Step:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the keys you wish to send below. Have each command on a new line.";
            // 
            // buttonRunMacro
            // 
            this.buttonRunMacro.Location = new System.Drawing.Point(316, 455);
            this.buttonRunMacro.Name = "buttonRunMacro";
            this.buttonRunMacro.Size = new System.Drawing.Size(75, 23);
            this.buttonRunMacro.TabIndex = 2;
            this.buttonRunMacro.Text = "Run macro";
            this.buttonRunMacro.UseVisualStyleBackColor = true;
            this.buttonRunMacro.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveMacro
            // 
            this.buttonSaveMacro.Location = new System.Drawing.Point(235, 455);
            this.buttonSaveMacro.Name = "buttonSaveMacro";
            this.buttonSaveMacro.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMacro.TabIndex = 4;
            this.buttonSaveMacro.Text = "Save macro";
            this.buttonSaveMacro.UseVisualStyleBackColor = true;
            this.buttonSaveMacro.Click += new System.EventHandler(this.buttonSaveMacro_Click);
            // 
            // buttonLoadMacro
            // 
            this.buttonLoadMacro.Location = new System.Drawing.Point(154, 455);
            this.buttonLoadMacro.Name = "buttonLoadMacro";
            this.buttonLoadMacro.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadMacro.TabIndex = 5;
            this.buttonLoadMacro.Text = "Load macro";
            this.buttonLoadMacro.UseVisualStyleBackColor = true;
            this.buttonLoadMacro.Click += new System.EventHandler(this.buttonLoadMacro_Click);
            // 
            // textBoxMacros
            // 
            this.textBoxMacros.Location = new System.Drawing.Point(6, 19);
            this.textBoxMacros.Multiline = true;
            this.textBoxMacros.Name = "textBoxMacros";
            this.textBoxMacros.Size = new System.Drawing.Size(385, 430);
            this.textBoxMacros.TabIndex = 0;
            this.textBoxMacros.Text = resources.GetString("textBoxMacros.Text");
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.groupBoxSkillOptions);
            this.tabPageSettings.Controls.Add(this.groupBoxMacroOptions);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(401, 486);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxSkillOptions
            // 
            this.groupBoxSkillOptions.Controls.Add(this.checkBoxSkipGreatStrides);
            this.groupBoxSkillOptions.Location = new System.Drawing.Point(8, 112);
            this.groupBoxSkillOptions.Name = "groupBoxSkillOptions";
            this.groupBoxSkillOptions.Size = new System.Drawing.Size(385, 100);
            this.groupBoxSkillOptions.TabIndex = 2;
            this.groupBoxSkillOptions.TabStop = false;
            this.groupBoxSkillOptions.Text = "Skill Options";
            // 
            // checkBoxSkipGreatStrides
            // 
            this.checkBoxSkipGreatStrides.AutoSize = true;
            this.checkBoxSkipGreatStrides.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSkipGreatStrides.Name = "checkBoxSkipGreatStrides";
            this.checkBoxSkipGreatStrides.Size = new System.Drawing.Size(348, 17);
            this.checkBoxSkipGreatStrides.TabIndex = 0;
            this.checkBoxSkipGreatStrides.Text = "Skip Great Strides and use Byregot\'s Blessing on Excellent Condition";
            this.checkBoxSkipGreatStrides.UseVisualStyleBackColor = true;
            // 
            // groupBoxMacroOptions
            // 
            this.groupBoxMacroOptions.Controls.Add(this.textBox1);
            this.groupBoxMacroOptions.Controls.Add(this.label2);
            this.groupBoxMacroOptions.Controls.Add(this.textBox2);
            this.groupBoxMacroOptions.Controls.Add(this.label3);
            this.groupBoxMacroOptions.Location = new System.Drawing.Point(8, 6);
            this.groupBoxMacroOptions.Name = "groupBoxMacroOptions";
            this.groupBoxMacroOptions.Size = new System.Drawing.Size(385, 100);
            this.groupBoxMacroOptions.TabIndex = 1;
            this.groupBoxMacroOptions.TabStop = false;
            this.groupBoxMacroOptions.Text = "Macro Options";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stop when CP is below:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "15000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum delay between each action before retrying: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMacro);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 512);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.groupBoxStats);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(401, 486);
            this.tabPageInfo.TabIndex = 2;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelExp);
            this.groupBoxStats.Controls.Add(this.labelExpHeader);
            this.groupBoxStats.Location = new System.Drawing.Point(8, 3);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(200, 100);
            this.groupBoxStats.TabIndex = 0;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(75, 16);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(13, 13);
            this.labelExp.TabIndex = 1;
            this.labelExp.Text = "0";
            // 
            // labelExpHeader
            // 
            this.labelExpHeader.AutoSize = true;
            this.labelExpHeader.Location = new System.Drawing.Point(6, 16);
            this.labelExpHeader.Name = "labelExpHeader";
            this.labelExpHeader.Size = new System.Drawing.Size(63, 13);
            this.labelExpHeader.TabIndex = 0;
            this.labelExpHeader.Text = "Experience:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 512);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crafting Bot";
            this.tabPageMacro.ResumeLayout(false);
            this.tabPageMacro.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBoxSkillOptions.ResumeLayout(false);
            this.groupBoxSkillOptions.PerformLayout();
            this.groupBoxMacroOptions.ResumeLayout(false);
            this.groupBoxMacroOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageMacro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRunMacro;
        private System.Windows.Forms.Button buttonSaveMacro;
        private System.Windows.Forms.Button buttonLoadMacro;
        private System.Windows.Forms.TextBox textBoxMacros;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkBoxSkipGreatStrides;
        private System.Windows.Forms.GroupBox groupBoxSkillOptions;
        private System.Windows.Forms.GroupBox groupBoxMacroOptions;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelExpHeader;
        private System.Windows.Forms.Label labelCurrentStep;
        private System.Windows.Forms.Label labelCurrentStepHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

    }
}

