using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project;

public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Input Validation
        if (string.IsNullOrWhiteSpace(txtFullName.Text))
        {
            MessageBox.Show("Please enter the employee's full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string query = "INSERT INTO Employees (FullName, Gender, HireDate, Salary, DepartmentID) " +
                       "VALUES (@name, @gender, @hDate, @salary, @deptId)";

        SqlParameter[] parameters = {
        new SqlParameter("@name", txtFullName.Text.Trim()),
        new SqlParameter("@gender", rbMale.Checked ? "Male" : "Female"),
        new SqlParameter("@hDate", dtpHireDate.Value),
        new SqlParameter("@salary", decimal.Parse(txtSalary.Text)),
        new SqlParameter("@deptId", cmbDepartment.SelectedValue)
    };

        DatabaseHelper db = new DatabaseHelper();
        db.ExecuteNonQuery(query, parameters);

        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadEmployeeData(); // Refresh DataGridView
    }
}
