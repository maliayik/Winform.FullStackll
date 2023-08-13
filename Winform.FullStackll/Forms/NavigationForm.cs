﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.FullStackll.DTOS;

namespace Winform.FullStackll.Forms
{
    public partial class NavigationForm : Form
    {
        UserLoginResponseDto responseDto;


        public NavigationForm(UserLoginResponseDto responseDto)
        {
            this.responseDto = responseDto;
            InitializeComponent();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm(responseDto.Fullname);
            form.Show();
            this.Hide();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            NotesForm form = new NotesForm(responseDto);
            form.Show();
            this.Hide();
        }
    }
}
