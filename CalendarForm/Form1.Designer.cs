namespace CalendarForm
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
            monthCalendar1 = new MonthCalendar();
            btn_addNew = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txt_newEventName = new TextBox();
            txt_eventOutput = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btn_addNew
            // 
            btn_addNew.Location = new Point(563, 93);
            btn_addNew.Name = "btn_addNew";
            btn_addNew.Size = new Size(75, 23);
            btn_addNew.TabIndex = 1;
            btn_addNew.Text = "Add new";
            btn_addNew.UseVisualStyleBackColor = true;
            btn_addNew.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(504, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Add a new event";
            // 
            // txt_newEventName
            // 
            txt_newEventName.Location = new Point(504, 64);
            txt_newEventName.Name = "txt_newEventName";
            txt_newEventName.PlaceholderText = "Event name";
            txt_newEventName.Size = new Size(200, 23);
            txt_newEventName.TabIndex = 4;
            // 
            // txt_eventOutput
            // 
            txt_eventOutput.Location = new Point(257, 35);
            txt_eventOutput.Multiline = true;
            txt_eventOutput.Name = "txt_eventOutput";
            txt_eventOutput.ReadOnly = true;
            txt_eventOutput.Size = new Size(241, 145);
            txt_eventOutput.TabIndex = 5;
            txt_eventOutput.TextChanged += txt_eventOutput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 17);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "Events";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 198);
            Controls.Add(label3);
            Controls.Add(txt_eventOutput);
            Controls.Add(txt_newEventName);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_addNew);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Gemporia Calendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btn_addNew;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txt_newEventName;
        private TextBox txt_eventOutput;
        private Label label3;
    }
}
