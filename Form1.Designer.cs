namespace Project;

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
        menuStrip1 = new MenuStrip();
        employeesToolStripMenuItem = new ToolStripMenuItem();
        departmentToolStripMenuItem = new ToolStripMenuItem();
        attendanceToolStripMenuItem = new ToolStripMenuItem();
        leaveRequestsToolStripMenuItem = new ToolStripMenuItem();
        contactUsToolStripMenuItem = new ToolStripMenuItem();
        existToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, departmentToolStripMenuItem, attendanceToolStripMenuItem, leaveRequestsToolStripMenuItem, contactUsToolStripMenuItem, existToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // employeesToolStripMenuItem
        // 
        employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
        employeesToolStripMenuItem.Size = new Size(76, 20);
        employeesToolStripMenuItem.Text = "Employees";
        employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
        // 
        // departmentToolStripMenuItem
        // 
        departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
        departmentToolStripMenuItem.Size = new Size(82, 20);
        departmentToolStripMenuItem.Text = "Department";
        // 
        // attendanceToolStripMenuItem
        // 
        attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
        attendanceToolStripMenuItem.Size = new Size(80, 20);
        attendanceToolStripMenuItem.Text = "Attendance";
        // 
        // leaveRequestsToolStripMenuItem
        // 
        leaveRequestsToolStripMenuItem.Name = "leaveRequestsToolStripMenuItem";
        leaveRequestsToolStripMenuItem.Size = new Size(96, 20);
        leaveRequestsToolStripMenuItem.Text = "Leave requests";
        // 
        // contactUsToolStripMenuItem
        // 
        contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
        contactUsToolStripMenuItem.Size = new Size(77, 20);
        contactUsToolStripMenuItem.Text = "Contact Us";
        // 
        // existToolStripMenuItem
        // 
        existToolStripMenuItem.Name = "existToolStripMenuItem";
        existToolStripMenuItem.Size = new Size(42, 20);
        existToolStripMenuItem.Text = "Exist";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "HR Management System";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem employeesToolStripMenuItem;
    private ToolStripMenuItem departmentToolStripMenuItem;
    private ToolStripMenuItem attendanceToolStripMenuItem;
    private ToolStripMenuItem leaveRequestsToolStripMenuItem;
    private ToolStripMenuItem contactUsToolStripMenuItem;
    private ToolStripMenuItem existToolStripMenuItem;
}
