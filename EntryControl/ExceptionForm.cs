using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EntryControl
{
    public partial class ExceptionForm : Form
    {
        private string messageStart = "При выполнении операции произошла следующая ошибка:" + Environment.NewLine;

        private ExceptionForm()
        {
            InitializeComponent();
        }

        public ExceptionForm(Exception exception) 
            : this()
        {
            lblMessage.Text = messageStart + exception.Message;

            StringBuilder advancedStringBuilder = new StringBuilder();
            if (exception.InnerException != null)
            {
                advancedStringBuilder.Append("InnerException: " + Environment.NewLine);
                advancedStringBuilder.Append(exception.InnerException.Message + Environment.NewLine);
                advancedStringBuilder.Append('-', 50);
                advancedStringBuilder.Append(Environment.NewLine);
            }

            advancedStringBuilder.Append("StackTrace:" + Environment.NewLine);
            advancedStringBuilder.Append(exception.StackTrace);

            tboxAdvanced.Text = advancedStringBuilder.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
