namespace Csc413_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddRequest = new Button();
            dispatch = new Button();
            btnCompleteMission = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCallerName = new TextBox();
            label4 = new Label();
            cmbEmergencyType = new ComboBox();
            label5 = new Label();
            numPriority = new NumericUpDown();
            label6 = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            lstRequests = new ListBox();
            lstNotifications = new ListBox();
            lstResponders = new ListBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPriority).BeginInit();
            SuspendLayout();
            // 
            // AddRequest
            // 
            AddRequest.Location = new Point(146, 254);
            AddRequest.Name = "AddRequest";
            AddRequest.Size = new Size(146, 29);
            AddRequest.TabIndex = 0;
            AddRequest.Text = "Add.Request\r\n\r\n\r\n";
            AddRequest.UseVisualStyleBackColor = true;
            AddRequest.Click += AddRequest_Click;
            // 
            // dispatch
            // 
            dispatch.Location = new Point(711, 827);
            dispatch.Name = "dispatch";
            dispatch.Size = new Size(146, 30);
            dispatch.TabIndex = 1;
            dispatch.Text = "Dispatch.reponder ";
            dispatch.UseVisualStyleBackColor = true;
            dispatch.Click += dispatch_Click;
            // 
            // btnCompleteMission
            // 
            btnCompleteMission.Location = new Point(1222, 828);
            btnCompleteMission.Name = "btnCompleteMission";
            btnCompleteMission.Size = new Size(146, 29);
            btnCompleteMission.TabIndex = 2;
            btnCompleteMission.Text = "complete.mission";
            btnCompleteMission.UseVisualStyleBackColor = true;
            btnCompleteMission.Click += btnCompleteMission_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(164, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 3;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(724, 50);
            label2.Name = "label2";
            label2.Size = new Size(133, 38);
            label2.TabIndex = 4;
            label2.Text = "Requests";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(1222, 50);
            label3.Name = "label3";
            label3.Size = new Size(167, 38);
            label3.TabIndex = 5;
            label3.Text = "Responders";
            label3.Click += label3_Click;
            // 
            // txtCallerName
            // 
            txtCallerName.Location = new Point(12, 104);
            txtCallerName.Name = "txtCallerName";
            txtCallerName.Size = new Size(127, 27);
            txtCallerName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(34, 72);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 7;
            label4.Text = "Caller Name";
            // 
            // cmbEmergencyType
            // 
            cmbEmergencyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmergencyType.FormattingEnabled = true;
            cmbEmergencyType.Items.AddRange(new object[] { "Ambulance", "Firefighter", "Police", "General" });
            cmbEmergencyType.Location = new Point(272, 104);
            cmbEmergencyType.Name = "cmbEmergencyType";
            cmbEmergencyType.Size = new Size(156, 28);
            cmbEmergencyType.TabIndex = 8;
            cmbEmergencyType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(272, 81);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 9;
            label5.Text = "Emergency Type";
            // 
            // numPriority
            // 
            numPriority.Location = new Point(12, 209);
            numPriority.Name = "numPriority";
            numPriority.Size = new Size(127, 27);
            numPriority.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(43, 176);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 11;
            label6.Text = "Priority";
            label6.Click += label6_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(272, 209);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(156, 27);
            txtDescription.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(272, 176);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 17;
            label8.Text = "Description";
            // 
            // lstRequests
            // 
            lstRequests.FormattingEnabled = true;
            lstRequests.Location = new Point(480, 91);
            lstRequests.Name = "lstRequests";
            lstRequests.Size = new Size(588, 704);
            lstRequests.TabIndex = 18;
            // 
            // lstNotifications
            // 
            lstNotifications.FormattingEnabled = true;
            lstNotifications.Location = new Point(2, 347);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new Size(448, 464);
            lstNotifications.TabIndex = 19;
            // 
            // lstResponders
            // 
            lstResponders.FormattingEnabled = true;
            lstResponders.Location = new Point(1098, 91);
            lstResponders.Name = "lstResponders";
            lstResponders.Size = new Size(406, 704);
            lstResponders.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(128, 306);
            label7.Name = "label7";
            label7.Size = new Size(187, 38);
            label7.TabIndex = 21;
            label7.Text = "Notifications";
            label7.Click += label7_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1547, 890);
            Controls.Add(label7);
            Controls.Add(lstResponders);
            Controls.Add(lstNotifications);
            Controls.Add(lstRequests);
            Controls.Add(label8);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(numPriority);
            Controls.Add(label5);
            Controls.Add(cmbEmergencyType);
            Controls.Add(label4);
            Controls.Add(txtCallerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCompleteMission);
            Controls.Add(dispatch);
            Controls.Add(AddRequest);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddRequest;
        private Button dispatch;
        private Button btnCompleteMission;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCallerName;
        private Label label4;
        private ComboBox cmbEmergencyType;
        private Label label5;
        private NumericUpDown numPriority;
        private Label label6;
        private TextBox txtDescription;
        private Label label8;
        private ListBox lstRequests;
        private ListBox lstNotifications;
        private ListBox lstResponders;
        private Label label7;
    }
}
