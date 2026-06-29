namespace Project;

partial class Form2
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
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        richTextBox1 = new RichTextBox();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(292, 344);
        button1.Name = "button1";
        button1.Size = new Size(226, 52);
        button1.TabIndex = 0;
        button1.Text = "Send Message";
        button1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(110, 31);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(110, 76);
        label2.Name = "label2";
        label2.Size = new Size(39, 15);
        label2.TabIndex = 2;
        label2.Text = "Email:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(110, 121);
        label3.Name = "label3";
        label3.Size = new Size(49, 15);
        label3.TabIndex = 3;
        label3.Text = "Subject:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(110, 191);
        label4.Name = "label4";
        label4.Size = new Size(56, 15);
        label4.TabIndex = 4;
        label4.Text = "Message:";
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(238, 191);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(337, 121);
        richTextBox1.TabIndex = 5;
        richTextBox1.Text = "";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(238, 23);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(337, 23);
        textBox1.TabIndex = 6;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(238, 68);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(337, 23);
        textBox2.TabIndex = 7;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(238, 113);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(337, 23);
        textBox3.TabIndex = 8;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(richTextBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Form2";
        Text = "Contact Us";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private RichTextBox richTextBox1;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
}