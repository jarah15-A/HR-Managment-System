namespace Project;

partial class Form3
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnSearch = new Button();
        dtpHireDate = new DateTimePicker();
        label5 = new Label();
        rbMale = new RadioButton();
        rbFemale = new RadioButton();
        txtFullName = new TextBox();
        txtSalary = new TextBox();
        cmbDepartment = new ComboBox();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(86, 51);
        label1.Name = "label1";
        label1.Size = new Size(69, 15);
        label1.TabIndex = 2;
        label1.Text = "Emp Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(86, 198);
        label2.Name = "label2";
        label2.Size = new Size(73, 15);
        label2.TabIndex = 3;
        label2.Text = "Department:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(86, 151);
        label3.Name = "label3";
        label3.Size = new Size(59, 15);
        label3.TabIndex = 4;
        label3.Text = "Hire Date:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(86, 103);
        label4.Name = "label4";
        label4.Size = new Size(48, 15);
        label4.TabIndex = 5;
        label4.Text = "Gender:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(104, 291);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(240, 291);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 7;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(420, 291);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 8;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(573, 291);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(75, 23);
        btnSearch.TabIndex = 9;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // dtpHireDate
        // 
        dtpHireDate.Location = new Point(240, 145);
        dtpHireDate.Name = "dtpHireDate";
        dtpHireDate.Size = new Size(200, 23);
        dtpHireDate.TabIndex = 10;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(86, 246);
        label5.Name = "label5";
        label5.Size = new Size(41, 15);
        label5.TabIndex = 11;
        label5.Text = "Salary:";
        // 
        // rbMale
        // 
        rbMale.AutoSize = true;
        rbMale.Location = new Point(240, 99);
        rbMale.Name = "rbMale";
        rbMale.Size = new Size(51, 19);
        rbMale.TabIndex = 12;
        rbMale.TabStop = true;
        rbMale.Text = "Male";
        rbMale.UseVisualStyleBackColor = true;
        // 
        // rbFemale
        // 
        rbFemale.AutoSize = true;
        rbFemale.Location = new Point(332, 99);
        rbFemale.Name = "rbFemale";
        rbFemale.Size = new Size(63, 19);
        rbFemale.TabIndex = 13;
        rbFemale.TabStop = true;
        rbFemale.Text = "Female";
        rbFemale.UseVisualStyleBackColor = true;
        // 
        // txtFullName
        // 
        txtFullName.Location = new Point(240, 43);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(155, 23);
        txtFullName.TabIndex = 14;
        // 
        // txtSalary
        // 
        txtSalary.Location = new Point(240, 238);
        txtSalary.Name = "txtSalary";
        txtSalary.Size = new Size(155, 23);
        txtSalary.TabIndex = 15;
        // 
        // cmbDepartment
        // 
        cmbDepartment.FormattingEnabled = true;
        cmbDepartment.Location = new Point(240, 195);
        cmbDepartment.Name = "cmbDepartment";
        cmbDepartment.Size = new Size(121, 23);
        cmbDepartment.TabIndex = 16;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(86, 320);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(691, 150);
        dataGridView1.TabIndex = 17;
        // 
        // Form3
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(836, 478);
        Controls.Add(dataGridView1);
        Controls.Add(cmbDepartment);
        Controls.Add(txtSalary);
        Controls.Add(txtFullName);
        Controls.Add(rbFemale);
        Controls.Add(rbMale);
        Controls.Add(label5);
        Controls.Add(dtpHireDate);
        Controls.Add(btnSearch);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form3";
        Text = "Employees Management";
        Load += Form3_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnSearch;
    private DateTimePicker dtpHireDate;
    private Label label5;
    private RadioButton rbMale;
    private RadioButton rbFemale;
    private TextBox txtFullName;
    private TextBox txtSalary;
    private ComboBox cmbDepartment;
    private DataGridView dataGridView1;
}