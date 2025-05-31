namespace AksenovaReflectionApp
{
    partial class MainForm
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
            browseButton = new Button();
            classComboBox = new ComboBox();
            constructorPanel = new FlowLayoutPanel();
            executeConstructorButton = new Button();
            methodComboBox = new ComboBox();
            methodParameterPanel = new FlowLayoutPanel();
            executeMethodButton = new Button();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(12, 12);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(130, 32);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // classComboBox
            // 
            classComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(12, 50);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(881, 33);
            classComboBox.TabIndex = 1;
            classComboBox.SelectedIndexChanged += classComboBox_SelectedIndexChanged;
            // 
            // constructorPanel
            // 
            constructorPanel.AutoScroll = true;
            constructorPanel.FlowDirection = FlowDirection.TopDown;
            constructorPanel.Location = new Point(12, 77);
            constructorPanel.Name = "constructorPanel";
            constructorPanel.Size = new Size(881, 251);
            constructorPanel.TabIndex = 2;
            // 
            // executeConstructorButton
            // 
            executeConstructorButton.Enabled = false;
            executeConstructorButton.Location = new Point(12, 334);
            executeConstructorButton.Name = "executeConstructorButton";
            executeConstructorButton.Size = new Size(130, 36);
            executeConstructorButton.TabIndex = 3;
            executeConstructorButton.Text = "Execute Constructor";
            executeConstructorButton.UseVisualStyleBackColor = true;
            executeConstructorButton.Click += executeConstructorButton_Click;
            // 
            // methodComboBox
            // 
            methodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            methodComboBox.FormattingEnabled = true;
            methodComboBox.Location = new Point(12, 376);
            methodComboBox.Name = "methodComboBox";
            methodComboBox.Size = new Size(881, 33);
            methodComboBox.TabIndex = 4;
            methodComboBox.SelectedIndexChanged += methodComboBox_SelectedIndexChanged;
            // 
            // methodParameterPanel
            // 
            methodParameterPanel.AutoScroll = true;
            methodParameterPanel.FlowDirection = FlowDirection.TopDown;
            methodParameterPanel.Location = new Point(12, 403);
            methodParameterPanel.Name = "methodParameterPanel";
            methodParameterPanel.Size = new Size(881, 319);
            methodParameterPanel.TabIndex = 5;
            // 
            // executeMethodButton
            // 
            executeMethodButton.Enabled = false;
            executeMethodButton.Location = new Point(12, 752);
            executeMethodButton.Name = "executeMethodButton";
            executeMethodButton.Size = new Size(130, 31);
            executeMethodButton.TabIndex = 6;
            executeMethodButton.Text = "Execute Method";
            executeMethodButton.UseVisualStyleBackColor = true;
            executeMethodButton.Click += executeMethodButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(937, 808);
            Controls.Add(executeMethodButton);
            Controls.Add(methodParameterPanel);
            Controls.Add(methodComboBox);
            Controls.Add(executeConstructorButton);
            Controls.Add(constructorPanel);
            Controls.Add(classComboBox);
            Controls.Add(browseButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Aksenova Reflection App";
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.FlowLayoutPanel constructorPanel;
        private System.Windows.Forms.Button executeConstructorButton;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.FlowLayoutPanel methodParameterPanel;
        private System.Windows.Forms.Button executeMethodButton;
    }
}
